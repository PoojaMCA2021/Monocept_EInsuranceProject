﻿// <auto-generated />
using System;
using EInsuranceProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EInsuranceProject.Migrations
{
    [DbContext(typeof(InsuranceContext))]
    [Migration("20231003174054_V3TestChange")]
    partial class V3TestChange
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AgentCustomer", b =>
                {
                    b.Property<int>("AgentsAgentId")
                        .HasColumnType("int");

                    b.Property<int>("CustomersCustomerId")
                        .HasColumnType("int");

                    b.HasKey("AgentsAgentId", "CustomersCustomerId");

                    b.HasIndex("CustomersCustomerId");

                    b.ToTable("AgentCustomer");
                });

            modelBuilder.Entity("CustomerPolicy", b =>
                {
                    b.Property<int>("CustomersCustomerId")
                        .HasColumnType("int");

                    b.Property<int>("PoliciesPolicyNo")
                        .HasColumnType("int");

                    b.HasKey("CustomersCustomerId", "PoliciesPolicyNo");

                    b.HasIndex("PoliciesPolicyNo");

                    b.ToTable("CustomerPolicy");
                });

            modelBuilder.Entity("EInsuranceProject.Model.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<string>("AdminFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AdminId");

                    b.HasIndex("UserId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("EInsuranceProject.Model.Agent", b =>
                {
                    b.Property<int>("AgentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AgentId"));

                    b.Property<string>("AgentFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AgentLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CommissionEarned")
                        .HasColumnType("float");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("Qualification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AgentId");

                    b.HasIndex("UserId");

                    b.ToTable("Agents");
                });

            modelBuilder.Entity("EInsuranceProject.Model.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nominee")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomineeRelation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.HasIndex("UserId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("EInsuranceProject.Model.Document", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DocumentId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("DocumentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DocumentId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("EInsuranceProject.Model.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("UserId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EInsuranceProject.Model.InsurancePlan", b =>
                {
                    b.Property<int>("PlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlanId"));

                    b.Property<string>("PlanName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Staus")
                        .HasColumnType("bit");

                    b.HasKey("PlanId");

                    b.ToTable("InsurancePlans");
                });

            modelBuilder.Entity("EInsuranceProject.Model.InsuranceScheme", b =>
                {
                    b.Property<int>("SchemeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SchemeId"));

                    b.Property<string>("SchemeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("SchemeId");

                    b.ToTable("InsuranceSchemes");
                });

            modelBuilder.Entity("EInsuranceProject.Model.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<int>("paymentType")
                        .HasColumnType("int");

                    b.HasKey("PaymentId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("EInsuranceProject.Model.Policy", b =>
                {
                    b.Property<int>("PolicyNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PolicyNo"));

                    b.Property<int>("InsuranceSchemeSchemeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("MaturityDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Premium")
                        .HasColumnType("float");

                    b.Property<int>("PremiumMode")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<double>("SumAssured")
                        .HasColumnType("float");

                    b.HasKey("PolicyNo");

                    b.HasIndex("InsuranceSchemeSchemeId");

                    b.ToTable("Policies");
                });

            modelBuilder.Entity("EInsuranceProject.Model.Role", b =>
                {
                    b.Property<int>("roleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("roleId"));

                    b.Property<string>("roleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("roleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("EInsuranceProject.Model.SchemeDetails", b =>
                {
                    b.Property<int>("DetailId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxAmount")
                        .HasColumnType("int");

                    b.Property<int>("MinAmount")
                        .HasColumnType("int");

                    b.Property<string>("SchemeImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DetailId");

                    b.ToTable("SchemeDetails");
                });

            modelBuilder.Entity("EInsuranceProject.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("InsurancePlanInsuranceScheme", b =>
                {
                    b.Property<int>("PlansPlanId")
                        .HasColumnType("int");

                    b.Property<int>("SchemesSchemeId")
                        .HasColumnType("int");

                    b.HasKey("PlansPlanId", "SchemesSchemeId");

                    b.HasIndex("SchemesSchemeId");

                    b.ToTable("InsurancePlanInsuranceScheme");
                });

            modelBuilder.Entity("PaymentPolicy", b =>
                {
                    b.Property<int>("PaymentId")
                        .HasColumnType("int");

                    b.Property<int>("PoliciesPolicyNo")
                        .HasColumnType("int");

                    b.HasKey("PaymentId", "PoliciesPolicyNo");

                    b.HasIndex("PoliciesPolicyNo");

                    b.ToTable("PaymentPolicy");
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.Property<int>("RolesroleId")
                        .HasColumnType("int");

                    b.Property<int>("UsersUserId")
                        .HasColumnType("int");

                    b.HasKey("RolesroleId", "UsersUserId");

                    b.HasIndex("UsersUserId");

                    b.ToTable("RoleUser");
                });

            modelBuilder.Entity("AgentCustomer", b =>
                {
                    b.HasOne("EInsuranceProject.Model.Agent", null)
                        .WithMany()
                        .HasForeignKey("AgentsAgentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EInsuranceProject.Model.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomersCustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CustomerPolicy", b =>
                {
                    b.HasOne("EInsuranceProject.Model.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomersCustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EInsuranceProject.Model.Policy", null)
                        .WithMany()
                        .HasForeignKey("PoliciesPolicyNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EInsuranceProject.Model.Admin", b =>
                {
                    b.HasOne("EInsuranceProject.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("EInsuranceProject.Model.Agent", b =>
                {
                    b.HasOne("EInsuranceProject.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("EInsuranceProject.Model.Customer", b =>
                {
                    b.HasOne("EInsuranceProject.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("EInsuranceProject.Model.Document", b =>
                {
                    b.HasOne("EInsuranceProject.Model.Customer", "Customer")
                        .WithMany("Documents")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("EInsuranceProject.Model.Employee", b =>
                {
                    b.HasOne("EInsuranceProject.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("EInsuranceProject.Model.Policy", b =>
                {
                    b.HasOne("EInsuranceProject.Model.InsuranceScheme", "InsuranceScheme")
                        .WithMany("Policies")
                        .HasForeignKey("InsuranceSchemeSchemeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InsuranceScheme");
                });

            modelBuilder.Entity("EInsuranceProject.Model.SchemeDetails", b =>
                {
                    b.HasOne("EInsuranceProject.Model.InsuranceScheme", "InsuranceScheme")
                        .WithOne("SchemeDetails")
                        .HasForeignKey("EInsuranceProject.Model.SchemeDetails", "DetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InsuranceScheme");
                });

            modelBuilder.Entity("InsurancePlanInsuranceScheme", b =>
                {
                    b.HasOne("EInsuranceProject.Model.InsurancePlan", null)
                        .WithMany()
                        .HasForeignKey("PlansPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EInsuranceProject.Model.InsuranceScheme", null)
                        .WithMany()
                        .HasForeignKey("SchemesSchemeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PaymentPolicy", b =>
                {
                    b.HasOne("EInsuranceProject.Model.Payment", null)
                        .WithMany()
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EInsuranceProject.Model.Policy", null)
                        .WithMany()
                        .HasForeignKey("PoliciesPolicyNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.HasOne("EInsuranceProject.Model.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesroleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EInsuranceProject.Model.User", null)
                        .WithMany()
                        .HasForeignKey("UsersUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EInsuranceProject.Model.Customer", b =>
                {
                    b.Navigation("Documents");
                });

            modelBuilder.Entity("EInsuranceProject.Model.InsuranceScheme", b =>
                {
                    b.Navigation("Policies");

                    b.Navigation("SchemeDetails");
                });
#pragma warning restore 612, 618
        }
    }
}