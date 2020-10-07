using System;
using System.Runtime.Serialization;


namespace WpfApplication1
{
    [Serializable]
    public class Patient
    {
        public String nId;
        public String name;
        public String lastName;
        public String doctorsName;
        public String disease;
        public String medications;
        public int age;
        public DateTime receptionDateTime;

        public Patient(){}
        // public Patient(SerializationInfo info, StreamingContext context)
        // {
        //     nId = (String)info.GetValue("ID", typeof(String));
        //     name = (String)info.GetValue("name", typeof(String));
        //     lastName = (String)info.GetValue("lastname", typeof(String));
        //     doctorsName = (String)info.GetValue("doctorname", typeof(String));
        //     disease = (String)info.GetValue("disease", typeof(String));
        //     medications = (String)info.GetValue("medication", typeof(String));
        //     age = (int)info.GetValue("age", typeof(String));
        // }
        // public void GetObjectData(SerializationInfo info, StreamingContext context)
        // {
        //     info.AddValue("ID",nId);
        //     info.AddValue("name",name);
        //     info.AddValue("lastname",lastName);
        //     info.AddValue("doctorname",doctorsName);
        //     info.AddValue("disease",disease);
        //     info.AddValue("medication",medications);
        //     info.AddValue("age",age);
        //}
    }
}