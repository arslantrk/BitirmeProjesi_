// <auto-generated />
using System;
using DataAccess.Concrete.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(ENabizContext))]
    [Migration("20220406194241_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Core.Entities.Concrete.OperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OperationClaims");
                });

            modelBuilder.Entity("Core.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Core.Entities.Concrete.UserOperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("OperationClaimId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserOperationClaims");
                });

            modelBuilder.Entity("Entity.Concrete.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("AppointmentId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Entity.Concrete.Clinic", b =>
                {
                    b.Property<int>("ClinicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClinicName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClinicId");

                    b.ToTable("Clinics");
                });

            modelBuilder.Entity("Entity.Concrete.ClinicPatient", b =>
                {
                    b.Property<int>("ClinicPatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ClinicId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("ClinicPatientId");

                    b.HasIndex("ClinicId");

                    b.HasIndex("PatientId");

                    b.ToTable("ClinicPatients");
                });

            modelBuilder.Entity("Entity.Concrete.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ClinicId")
                        .HasColumnType("int");

                    b.Property<string>("DoctorArea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DoctorBirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DoctorGender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorTc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LaboratoryId")
                        .HasColumnType("int");

                    b.HasKey("DoctorId");

                    b.HasIndex("ClinicId");

                    b.HasIndex("LaboratoryId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("Entity.Concrete.Laboratory", b =>
                {
                    b.Property<int>("LabId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("LabResult")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ResultDate")
                        .HasColumnType("datetime2");

                    b.HasKey("LabId");

                    b.HasIndex("PatientId");

                    b.ToTable("Laboratorys");
                });

            modelBuilder.Entity("Entity.Concrete.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BirthPlace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PatientBirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PatientDistrict")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientGender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientProvince")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientSGK")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Entity.Concrete.Prescription", b =>
                {
                    b.Property<int>("PrescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DoctorComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PrescriptionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PrescriptionId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("Entity.Concrete.Appointment", b =>
                {
                    b.HasOne("Entity.Concrete.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Concrete.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Entity.Concrete.ClinicPatient", b =>
                {
                    b.HasOne("Entity.Concrete.Clinic", "Clinic")
                        .WithMany("ClinicPatients")
                        .HasForeignKey("ClinicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Concrete.Patient", "Patient")
                        .WithMany("ClinicPatients")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinic");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Entity.Concrete.Doctor", b =>
                {
                    b.HasOne("Entity.Concrete.Clinic", "Clinic")
                        .WithMany("Doctors")
                        .HasForeignKey("ClinicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Concrete.Laboratory", "Laboratory")
                        .WithMany("Doctors")
                        .HasForeignKey("LaboratoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinic");

                    b.Navigation("Laboratory");
                });

            modelBuilder.Entity("Entity.Concrete.Laboratory", b =>
                {
                    b.HasOne("Entity.Concrete.Patient", "Patient")
                        .WithMany("Laboratories")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Entity.Concrete.Prescription", b =>
                {
                    b.HasOne("Entity.Concrete.Doctor", "Doctor")
                        .WithMany("Prescriptions")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Concrete.Patient", "Patient")
                        .WithMany("Prescriptions")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Entity.Concrete.Clinic", b =>
                {
                    b.Navigation("ClinicPatients");

                    b.Navigation("Doctors");
                });

            modelBuilder.Entity("Entity.Concrete.Doctor", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("Entity.Concrete.Laboratory", b =>
                {
                    b.Navigation("Doctors");
                });

            modelBuilder.Entity("Entity.Concrete.Patient", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("ClinicPatients");

                    b.Navigation("Laboratories");

                    b.Navigation("Prescriptions");
                });
#pragma warning restore 612, 618
        }
    }
}
