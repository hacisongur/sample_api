

using System.ComponentModel.DataAnnotations;

namespace sample_api.Models
{
    
    public class person
    {
        [Key]
        public string id { get; set; }//guid? 
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string workEmail { get; set; }
        public string mobilePhone { get; set; }
        public string workPhone { get; set; }
        public string gender { get; set; }
        public string accessType { get; set; }
        public string nationality { get; set; }
        public int idNumber { get; set; }
        public DateTime employmentStartDate { get; set; }
        public string contractType { get; set; }
        public DateTime contractEndDate { get; set; }
        public DateTime birthday { get; set; }
        public string maritalStatus { get; set; }
        public string partnerWorkStatus { get; set; }
        public string militaryService { get; set; }
        public DateTime militaryServiceDelayDate { get; set; }
        public string educationLevel { get; set; }
        public string educationStatus { get; set; }
        public string educationalInstitution { get; set; }
        public bool status { get; set; }
        public bool tourStatus { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public string levelOfDisability { get; set; }
        public int numberOfChildren { get; set; }
        public string bloodType { get; set; }
        public string accrualStartDate { get; set; }
        //public List<unitList> unitList { get; set; }

    }
}