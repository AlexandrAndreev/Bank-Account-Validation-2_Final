
using Bank_Account_Validation_2_Final;
using System.Text.Json;

BankAccountValidation2_FinalPlaneClient bankAccountValidation2_FinalPlaneClient = new 
    BankAccountValidation2_FinalPlaneClient("You_client_id" , "You_client_secret", EnvironmentType.Sandbox);
Console.WriteLine("Test ACHCheckPrescreenLiteClient:");
Console.WriteLine("Test GetReport:");

var reportRequestModel = JsonSerializer.Serialize<ACHCheckPrescreenLiteReportRequstModel>(new ACHCheckPrescreenLiteReportRequstModel()
{
    PersonInfo = new PersonInfo()
    {
        PersonName = new PersonName() { FirstName = "Kevin", LastName = "Williams" }
    },
    ContactInfo = new ContactInfo()
    {
        PhoneNum = new PhoneNum() { Phone = "2049529655", PhoneType = "2" }
    },
    EmailAddr = "kwilliams@testmail.com",
    PostAddr = new PostAddr()
    {
        Addr1 = "5982 Murdock Ave",
        City = "Bethel Park",
        PostalCode = "15107",
        StateProv = "NH"
    },
    TINInfo = new TINInfo()
    {
        TaxId = "166605210",
        TINType = "1"
    },
    DriversLicense = new DriversLicense()
    {
        LicenseNum = "A123456789012",
        StateProv = "FL"
    },
    EmploymentHistory = new EmploymentHistory()
    {
        OrgInfo = new OrgInfo()
        {
            Name = "Andover Sytstems"
        }
    },
    BankAccount = new BankAccount()
    {
        OrgInfo = new OrgInfo()
        {
            Name = "Bank Of America"
        },
        AccountNum = "111010111",
        RoutingNumber = "053200983",
        TypeOfBankAcct = "1"
    },
    IncomeInfo = new IncomeInfo()
    {
        MonthlyIncome = new MonthlyIncome()
        {
            Amt = "4100.00",
            CurCode = "USD"
        },
        PmtFreq = "BIWEEKLY",
        PayPerPeriod = new PayPerPeriod()
        {
            Amt = "2000.00",
            CurCode = "USD"
        },
        DtOfNextPaycheck = "2009-01-15",
        DtOfSecondPaycheck = "2009-01-31"
    },
    References = new References()
    {
        ContactName = "Mark Taylor",
        PhoneNum = new PhoneNum()
        {
            PhoneType = "2",
            Phone = "7831113332"
        }
    },
    CheckAmt = new CheckAmt()
    {
        Amt = "46.46"
    },
    CheckNum = "1234",
    RuleNum = "500",
    LaneId = "113"
});

Console.WriteLine(bankAccountValidation2_FinalPlaneClient.ACHCheckPrescreenLiteClient.GetReport(reportRequestModel).ToString());
Console.WriteLine("Test GetArchiveReport:");
Console.WriteLine(bankAccountValidation2_FinalPlaneClient.ACHCheckPrescreenLiteClient.GetArchiveReport("{EB26FCC9-159B-4308-A866-60979CD74877}").ToString());
Console.WriteLine("Test ReportPerformance:");
Console.WriteLine(bankAccountValidation2_FinalPlaneClient.ACHCheckPrescreenLiteClient.GetReportPerformance("{\"CheckInfo\":{\"accountNumber\":\"1007\",\"amount\":25.45,\"checkNumber\":150,\"closureReason\":\"AccountAbuse\",\"returnDate\":\"2020-10-16\",\"returnReason\":\"R01\",\"routingNumber\":\"052001633\",\"secCode\":\"WEB\",\"serviceFee\":15,\"type\":\"P\",\"verificationResult\":\"A\"},\"ConsumerInfo\":{\"Address\":{\"city\":\"Memphis\",\"line\":\"555MainSt\",\"state\":\"TN\",\"zipCode\":\"05555\"},\"Emails\":[{\"address\":\"myemailbox@mailbox.com\",\"type\":\"HOME\"}],\"Identifications\":[{\"number\":\"S12345678\",\"state\":\"NY\",\"type\":\"DL\"}],\"Name\":{\"first\":\"John\",\"last\":\"Doe\",\"middle\":\"K\"},\"PhoneNumbers\":[{\"number\":\"5076625555\",\"type\":\"HOME\"}]},\"MerchantInfo\":{\"groupNumber\":\"10\",\"laneNumber\":\"12\",\"mccCode\":\"518\",\"merchantNumber\":\"300\",\"name\":\"PrecisePayments\",\"ruleNumber\":\"5\",\"siteNumber\":\"500200\",\"zipCode\":\"08163\"},\"TransactionInfo\":{\"clientReferenceNumber\":\"NRC3049115\",\"date\":\"2020-10-16\",\"time\":\"14:35:00\",\"transactionNumber\":\"1235\",\"type\":\"10\"}}").ToString());