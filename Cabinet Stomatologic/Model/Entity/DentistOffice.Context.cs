﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cabinet_Stomatologic.Model.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DentistOfficeEntities2 : DbContext
    {
        public DentistOfficeEntities2()
            : base("name=DentistOfficeEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<account> accounts { get; set; }
        public virtual DbSet<appointment> appointments { get; set; }
        public virtual DbSet<bill> bills { get; set; }
        public virtual DbSet<doctor> doctors { get; set; }
        public virtual DbSet<doctorPhoto> doctorPhotoes { get; set; }
        public virtual DbSet<doctorProcedure> doctorProcedures { get; set; }
        public virtual DbSet<patient> patients { get; set; }
        public virtual DbSet<payment> payments { get; set; }
        public virtual DbSet<PayMethod> PayMethods { get; set; }
        public virtual DbSet<personinformation> personinformations { get; set; }
        public virtual DbSet<statusBill> statusBills { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }
    
        public virtual int AddAccount(string email, string pass, Nullable<int> idUserType)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            var idUserTypeParameter = idUserType.HasValue ?
                new ObjectParameter("idUserType", idUserType) :
                new ObjectParameter("idUserType", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddAccount", emailParameter, passParameter, idUserTypeParameter);
        }
    
        public virtual int AddAppointment(Nullable<System.DateTime> date, Nullable<int> duration, Nullable<int> iddoc, Nullable<int> idpatient, Nullable<int> idprocedure)
        {
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var durationParameter = duration.HasValue ?
                new ObjectParameter("duration", duration) :
                new ObjectParameter("duration", typeof(int));
    
            var iddocParameter = iddoc.HasValue ?
                new ObjectParameter("iddoc", iddoc) :
                new ObjectParameter("iddoc", typeof(int));
    
            var idpatientParameter = idpatient.HasValue ?
                new ObjectParameter("idpatient", idpatient) :
                new ObjectParameter("idpatient", typeof(int));
    
            var idprocedureParameter = idprocedure.HasValue ?
                new ObjectParameter("idprocedure", idprocedure) :
                new ObjectParameter("idprocedure", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddAppointment", dateParameter, durationParameter, iddocParameter, idpatientParameter, idprocedureParameter);
        }
    
        public virtual int AddDoctorDetails(string fullname, string adress, string phone, string email)
        {
            var fullnameParameter = fullname != null ?
                new ObjectParameter("fullname", fullname) :
                new ObjectParameter("fullname", typeof(string));
    
            var adressParameter = adress != null ?
                new ObjectParameter("adress", adress) :
                new ObjectParameter("adress", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddDoctorDetails", fullnameParameter, adressParameter, phoneParameter, emailParameter);
        }
    
        public virtual int AddMedicalProcedure(Nullable<int> id, string name, Nullable<int> price)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddMedicalProcedure", idParameter, nameParameter, priceParameter);
        }
    
        public virtual int AddPatientDetails(string fullname, string adress, string phone, string email, Nullable<int> docId)
        {
            var fullnameParameter = fullname != null ?
                new ObjectParameter("fullname", fullname) :
                new ObjectParameter("fullname", typeof(string));
    
            var adressParameter = adress != null ?
                new ObjectParameter("adress", adress) :
                new ObjectParameter("adress", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var docIdParameter = docId.HasValue ?
                new ObjectParameter("docId", docId) :
                new ObjectParameter("docId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddPatientDetails", fullnameParameter, adressParameter, phoneParameter, emailParameter, docIdParameter);
        }
    
        public virtual int AddPhotoAndFindId(byte[] img, ObjectParameter id)
        {
            var imgParameter = img != null ?
                new ObjectParameter("img", img) :
                new ObjectParameter("img", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddPhotoAndFindId", imgParameter, id);
        }
    
        public virtual int DeactivateAccount(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeactivateAccount", idParameter);
        }
    
        public virtual int DeactivateAppointment(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeactivateAppointment", idParameter);
        }
    
        public virtual int DeactivateDoctor(Nullable<int> idDoc)
        {
            var idDocParameter = idDoc.HasValue ?
                new ObjectParameter("idDoc", idDoc) :
                new ObjectParameter("idDoc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeactivateDoctor", idDocParameter);
        }
    
        public virtual int DeactivateMedicalProcedure(Nullable<int> id, string name, Nullable<int> price)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeactivateMedicalProcedure", idParameter, nameParameter, priceParameter);
        }
    
        public virtual int DeactivatePatient(Nullable<int> idDoc)
        {
            var idDocParameter = idDoc.HasValue ?
                new ObjectParameter("idDoc", idDoc) :
                new ObjectParameter("idDoc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeactivatePatient", idDocParameter);
        }
    
        public virtual int FindDoctor(string firstName, string lastName, ObjectParameter idDoctor)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("firstName", firstName) :
                new ObjectParameter("firstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("lastName", lastName) :
                new ObjectParameter("lastName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("FindDoctor", firstNameParameter, lastNameParameter, idDoctor);
        }
    
        public virtual int FindPatient(string firstName, string lastName, ObjectParameter idPatient)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("firstName", firstName) :
                new ObjectParameter("firstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("lastName", lastName) :
                new ObjectParameter("lastName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("FindPatient", firstNameParameter, lastNameParameter, idPatient);
        }
    
        public virtual int FindPersonInformation(string email, ObjectParameter idPersonInformation)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("FindPersonInformation", emailParameter, idPersonInformation);
        }
    
        public virtual int ModifyAccount(Nullable<int> id, string email, string pass)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModifyAccount", idParameter, emailParameter, passParameter);
        }
    
        public virtual int ModifyAppointment(Nullable<System.DateTime> date, Nullable<int> duration, Nullable<int> id, Nullable<int> iddoc, Nullable<int> idpatient, Nullable<int> idprocedure)
        {
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var durationParameter = duration.HasValue ?
                new ObjectParameter("duration", duration) :
                new ObjectParameter("duration", typeof(int));
    
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var iddocParameter = iddoc.HasValue ?
                new ObjectParameter("iddoc", iddoc) :
                new ObjectParameter("iddoc", typeof(int));
    
            var idpatientParameter = idpatient.HasValue ?
                new ObjectParameter("idpatient", idpatient) :
                new ObjectParameter("idpatient", typeof(int));
    
            var idprocedureParameter = idprocedure.HasValue ?
                new ObjectParameter("idprocedure", idprocedure) :
                new ObjectParameter("idprocedure", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModifyAppointment", dateParameter, durationParameter, idParameter, iddocParameter, idpatientParameter, idprocedureParameter);
        }
    
        public virtual int UpdateDoctorDetails(Nullable<int> idDoc, string fullname, string adress, string phone, string email)
        {
            var idDocParameter = idDoc.HasValue ?
                new ObjectParameter("idDoc", idDoc) :
                new ObjectParameter("idDoc", typeof(int));
    
            var fullnameParameter = fullname != null ?
                new ObjectParameter("fullname", fullname) :
                new ObjectParameter("fullname", typeof(string));
    
            var adressParameter = adress != null ?
                new ObjectParameter("adress", adress) :
                new ObjectParameter("adress", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateDoctorDetails", idDocParameter, fullnameParameter, adressParameter, phoneParameter, emailParameter);
        }
    
        public virtual int UpdateMedicalProcedure(Nullable<int> id, string name, Nullable<int> price)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateMedicalProcedure", idParameter, nameParameter, priceParameter);
        }
    
        public virtual int UpdatePatientDetails(Nullable<int> idpatient, string fullname, string adress, string phone, string email, Nullable<int> docId)
        {
            var idpatientParameter = idpatient.HasValue ?
                new ObjectParameter("idpatient", idpatient) :
                new ObjectParameter("idpatient", typeof(int));
    
            var fullnameParameter = fullname != null ?
                new ObjectParameter("fullname", fullname) :
                new ObjectParameter("fullname", typeof(string));
    
            var adressParameter = adress != null ?
                new ObjectParameter("adress", adress) :
                new ObjectParameter("adress", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var docIdParameter = docId.HasValue ?
                new ObjectParameter("docId", docId) :
                new ObjectParameter("docId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdatePatientDetails", idpatientParameter, fullnameParameter, adressParameter, phoneParameter, emailParameter, docIdParameter);
        }
    
        public virtual ObjectResult<SearchPatient_Result> SearchPatient(string fullname, string email)
        {
            var fullnameParameter = fullname != null ?
                new ObjectParameter("fullname", fullname) :
                new ObjectParameter("fullname", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchPatient_Result>("SearchPatient", fullnameParameter, emailParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> CalculateSalaryOnMonth(Nullable<int> id, ObjectParameter salary)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("CalculateSalaryOnMonth", idParameter, salary);
        }
    }
}
