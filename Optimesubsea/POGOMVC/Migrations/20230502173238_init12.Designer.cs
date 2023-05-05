﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using POGOMVC.DataLayer;

#nullable disable

namespace POGOMVC.Migrations
{
    [DbContext(typeof(GasStationProjectDbContext))]
    [Migration("20230502173238_init12")]
    partial class init12
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("POGOMVC.Models.FileUploadModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("C1")
                        .HasColumnType("int");

                    b.Property<int>("C2")
                        .HasColumnType("int");

                    b.Property<DateTime?>("C3")
                        .HasColumnType("datetime2");

                    b.Property<int>("C4")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("t_FileUploadModels");
                });

            modelBuilder.Entity("POGOMVC.Models.PasscodeRecoveryQuestionnaireModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("QuestionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionNarration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("m_PasscodeRecoveryQuestionnaire");
                });

            modelBuilder.Entity("POGOMVC.Models.ProjectModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ProjectDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ProjectEndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ProjectStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProjectType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SuperUserId")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UploadDataEndUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SuperUserId");

                    b.HasIndex("UploadDataEndUserId");

                    b.ToTable("t_ProjectTable");
                });

            modelBuilder.Entity("POGOMVC.Models.RolesModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Narration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("m_Roles");
                });

            modelBuilder.Entity("POGOMVC.Models.UserHasProjectsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserRegistrationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserRegistrationId");

                    b.ToTable("t_UserHasProjects");
                });

            modelBuilder.Entity("POGOMVC.Models.UserRegistrationModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Narration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Passcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasscodeRecoveryAnswer1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PasscodeRecoveryQuestionnaireId1Id")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserRoleIdId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PasscodeRecoveryQuestionnaireId1Id");

                    b.HasIndex("UserRoleIdId");

                    b.ToTable("t_UserRegistration");
                });

            modelBuilder.Entity("POGOMVC.Models.ProjectModel", b =>
                {
                    b.HasOne("POGOMVC.Models.UserRegistrationModel", "SuperUser")
                        .WithMany()
                        .HasForeignKey("SuperUserId");

                    b.HasOne("POGOMVC.Models.UserRegistrationModel", "UploadDataEndUser")
                        .WithMany()
                        .HasForeignKey("UploadDataEndUserId");

                    b.Navigation("SuperUser");

                    b.Navigation("UploadDataEndUser");
                });

            modelBuilder.Entity("POGOMVC.Models.UserHasProjectsModel", b =>
                {
                    b.HasOne("POGOMVC.Models.ProjectModel", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId");

                    b.HasOne("POGOMVC.Models.UserRegistrationModel", "UserRegistration")
                        .WithMany()
                        .HasForeignKey("UserRegistrationId");

                    b.Navigation("Project");

                    b.Navigation("UserRegistration");
                });

            modelBuilder.Entity("POGOMVC.Models.UserRegistrationModel", b =>
                {
                    b.HasOne("POGOMVC.Models.PasscodeRecoveryQuestionnaireModel", "PasscodeRecoveryQuestionnaireId1")
                        .WithMany("UserRegistrations")
                        .HasForeignKey("PasscodeRecoveryQuestionnaireId1Id");

                    b.HasOne("POGOMVC.Models.RolesModel", "UserRoleId")
                        .WithMany("UserRegistrations")
                        .HasForeignKey("UserRoleIdId");

                    b.Navigation("PasscodeRecoveryQuestionnaireId1");

                    b.Navigation("UserRoleId");
                });

            modelBuilder.Entity("POGOMVC.Models.PasscodeRecoveryQuestionnaireModel", b =>
                {
                    b.Navigation("UserRegistrations");
                });

            modelBuilder.Entity("POGOMVC.Models.RolesModel", b =>
                {
                    b.Navigation("UserRegistrations");
                });
#pragma warning restore 612, 618
        }
    }
}
