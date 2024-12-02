using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Validation_2_Final
{
    public class ACHCheckPrescreenLiteReportRequstModel
    {
        public PersonInfo PersonInfo { get; set; }
        public ContactInfo ContactInfo { get; set; }
        public string EmailAddr { get; set; }
        public PostAddr PostAddr { get; set; }
        public TINInfo TINInfo { get; set; }
        public DriversLicense DriversLicense { get; set; }
        public EmploymentHistory EmploymentHistory { get; set; }
        public BankAccount BankAccount { get; set; }
        public IncomeInfo IncomeInfo { get; set; }
        public References References { get; set; }
        public CheckAmt CheckAmt { get; set; }
        public string CheckNum { get; set; }
        public string RuleNum { get; set; }
        public string LaneId { get; set; }
    }

    public class CheckAmt
    {
        public string Amt { get; set; }
    }

    public class References
    {
        public PhoneNum PhoneNum { get; set; }
        public string ContactName { get; set; }
    }

    public class IncomeInfo
    {
        public MonthlyIncome MonthlyIncome { get; set; }
        public string PmtFreq { get; set; }
        public PayPerPeriod PayPerPeriod { get; set; }
        public string DtOfNextPaycheck { get; set; }
        public string DtOfSecondPaycheck { get; set; }
    }

    public class PayPerPeriod
    {
        public string Amt { get; set; }
        public string CurCode { get; set; }
    }

    public class MonthlyIncome
    {
        public string Amt { get; set; }
        public string CurCode { get; set; }
    }

    public class BankAccount
    {
        public OrgInfo OrgInfo { get; set; }
        public string RoutingNumber { get; set; }
        public string AccountNum { get; set; }
        public string TypeOfBankAcct { get; set; }
    }

    public class EmploymentHistory
    {
        public OrgInfo OrgInfo { get; set; }
    }

    public class OrgInfo
    {
        public string Name { get; set; }
    }

    public class DriversLicense
    {
        public string LicenseNum { get; set; }
        public string StateProv { get; set; }
    }

    public class TINInfo
    {
        public string TINType { get; set; }
        public string TaxId { get; set; }
    }

    public class PostAddr
    {
        public string Addr1 { get; set; }
        public string City { get; set; }
        public string StateProv { get; set; }
        public string PostalCode { get; set; }
    }

    public class ContactInfo
    {
        public PhoneNum PhoneNum { get; set; }
    }

    public class PhoneNum
    {
        public string PhoneType { get; set; }
        public string Phone { get; set; }
    }

    public class PersonInfo
    {
        public PersonName PersonName { get; set; }
    }

    public class PersonName
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }

    public class ACHCheckPrescreenLiteReportPerfomanceRequstModel
    {
        public Checkinfo CheckInfo { get; set; }
        public Consumerinfo ConsumerInfo { get; set; }
        public Merchantinfo MerchantInfo { get; set; }
        public Transactioninfo TransactionInfo { get; set; }
    }

    public class Checkinfo
    {
        public string accountNumber { get; set; }
        public float amount { get; set; }
        public int checkNumber { get; set; }
        public string closureReason { get; set; }
        public string returnDate { get; set; }
        public string returnReason { get; set; }
        public string routingNumber { get; set; }
        public string secCode { get; set; }
        public int serviceFee { get; set; }
        public string type { get; set; }
        public string verificationResult { get; set; }
    }

    public class Consumerinfo
    {
        public Address Address { get; set; }
        public Email[] Emails { get; set; }
        public Identification[] Identifications { get; set; }
        public Name Name { get; set; }
        public Phonenumber[] PhoneNumbers { get; set; }
    }

    public class Address
    {
        public string city { get; set; }
        public string line { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }
    }

    public class Name
    {
        public string first { get; set; }
        public string last { get; set; }
        public string middle { get; set; }
    }

    public class Email
    {
        public string address { get; set; }
        public string type { get; set; }
    }

    public class Identification
    {
        public string number { get; set; }
        public string state { get; set; }
        public string type { get; set; }
    }

    public class Phonenumber
    {
        public string number { get; set; }
        public string type { get; set; }
    }

    public class Merchantinfo
    {
        public string groupNumber { get; set; }
        public string laneNumber { get; set; }
        public string mccCode { get; set; }
        public string merchantNumber { get; set; }
        public string name { get; set; }
        public string ruleNumber { get; set; }
        public string siteNumber { get; set; }
        public string zipCode { get; set; }
    }

    public class Transactioninfo
    {
        public string clientReferenceNumber { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public string transactionNumber { get; set; }
        public string type { get; set; }
    }
}
