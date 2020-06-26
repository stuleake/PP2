﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace TQ.Data.FeeCalculator.Migrations
{
    [DbContext(typeof(FeeCalculatorContext))]
    [Migration("20200308054239_1698_InitialSetup")]
    partial class _1698_InitialSetup
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TQ.Data.FeeCalculator.Schemas.Dbo.Answer", b =>
                {
                    b.Property<Guid>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ParameterAnswer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParameterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RowNo")
                        .HasColumnType("int");

                    b.Property<Guid>("SessionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SessionType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnswerId");

                    b.ToTable("Answers", "dbo");
                });

            modelBuilder.Entity("TQ.Data.FeeCalculator.Schemas.Dbo.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sequence")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories", "dbo");
                });

            modelBuilder.Entity("TQ.Data.FeeCalculator.Schemas.Dbo.DefPackage", b =>
                {
                    b.Property<Guid>("DefPackageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DefPackageId");

                    b.ToTable("DefPackages", "dbo");
                });

            modelBuilder.Entity("TQ.Data.FeeCalculator.Schemas.Dbo.ParamDataType", b =>
                {
                    b.Property<Guid>("ParamDataTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ParamDataTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ParamDataTypeId");

                    b.ToTable("ParamDataTypes", "dbo");
                });

            modelBuilder.Entity("TQ.Data.FeeCalculator.Schemas.Dbo.Parameter", b =>
                {
                    b.Property<Guid>("ParameterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MasterValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ParamDataTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Product")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tenant")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ParameterId");

                    b.HasIndex("ParamDataTypeId");

                    b.ToTable("Parameters", "dbo");
                });

            modelBuilder.Entity("TQ.Data.FeeCalculator.Schemas.Dbo.QSCollectionTypeRuleMapping", b =>
                {
                    b.Property<Guid>("QSCollectionTypeRuleMappingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ApplicationTypeRefNo")
                        .HasColumnType("int");

                    b.Property<string>("QSCollectionVersion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RuleDefId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("QSCollectionTypeRuleMappingId");

                    b.HasIndex("RuleDefId");

                    b.ToTable("QSCollectionTypeRuleMappings", "dbo");
                });

            modelBuilder.Entity("TQ.Data.FeeCalculator.Schemas.Dbo.QSRuleMapping", b =>
                {
                    b.Property<Guid>("QSRuleMappingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("QSNo")
                        .HasColumnType("int");

                    b.Property<string>("QSVersion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RuleDefId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("QSRuleMappingId");

                    b.HasIndex("RuleDefId");

                    b.ToTable("QsRuleMapping", "dbo");
                });

            modelBuilder.Entity("TQ.Data.FeeCalculator.Schemas.Dbo.Qsr", b =>
                {
                    b.Property<Guid>("QsrId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("QSCollectionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("QsrId");

                    b.ToTable("Qsr", "dbo");
                });

            modelBuilder.Entity("TQ.Data.FeeCalculator.Schemas.Dbo.RuleDef", b =>
                {
                    b.Property<Guid>("RuleDefId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DefPackageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Product")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReferenceId")
                        .HasColumnType("int");

                    b.Property<string>("RuleDefinition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RuleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Tenant")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RuleDefId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DefPackageId");

                    b.ToTable("RuleDefs", "dbo");
                });

            modelBuilder.Entity("TQ.Data.FeeCalculator.Schemas.Dbo.RuleDefParameterMapping", b =>
                {
                    b.Property<Guid>("RuleDefParameterMappingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("OutputOperation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ParameterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ParameterType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RuleDefId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Sequence")
                        .HasColumnType("int");

                    b.HasKey("RuleDefParameterMappingId");

                    b.HasIndex("ParameterId");

                    b.HasIndex("RuleDefId");

                    b.ToTable("RuleDefParameterMappings", "dbo");
                });

            modelBuilder.Entity("TQ.Data.FeeCalculator.Schemas.Dbo.Step", b =>
                {
                    b.Property<Guid>("StepId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ApplicationTypeRefId")
                        .HasColumnType("int");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Inputs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFinalOutput")
                        .HasColumnType("bit");

                    b.Property<string>("Output")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OutputDataType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OutputParamName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RuleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RuleNo")
                        .HasColumnType("int");

                    b.Property<Guid>("SessionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SessionType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StepId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("RuleId");

                    b.ToTable("Steps", "dbo");
                });

            modelBuilder.Entity("TQ.Data.FeeCalculator.Schemas.Dbo.TestSetHeader", b =>
                {
                    b.Property<Guid>("TestSetHeaderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TestSetHeaderId");

                    b.ToTable("TestSetHeaders", "dbo");
                });

            modelBuilder.Entity("TQ.Data.FeeCalculator.Schemas.Dbo.Parameter", b =>
                {
                    b.HasOne("TQ.Data.FeeCalculator.Schemas.Dbo.ParamDataType", "ParamDataType")
                        .WithMany()
                        .HasForeignKey("ParamDataTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TQ.Data.FeeCalculator.Schemas.Dbo.QSCollectionTypeRuleMapping", b =>
                {
                    b.HasOne("TQ.Data.FeeCalculator.Schemas.Dbo.RuleDef", "RuleDef")
                        .WithMany()
                        .HasForeignKey("RuleDefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TQ.Data.FeeCalculator.Schemas.Dbo.QSRuleMapping", b =>
                {
                    b.HasOne("TQ.Data.FeeCalculator.Schemas.Dbo.RuleDef", "RuleDef")
                        .WithMany()
                        .HasForeignKey("RuleDefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TQ.Data.FeeCalculator.Schemas.Dbo.RuleDef", b =>
                {
                    b.HasOne("TQ.Data.FeeCalculator.Schemas.Dbo.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TQ.Data.FeeCalculator.Schemas.Dbo.DefPackage", "DefPackage")
                        .WithMany()
                        .HasForeignKey("DefPackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TQ.Data.FeeCalculator.Schemas.Dbo.RuleDefParameterMapping", b =>
                {
                    b.HasOne("TQ.Data.FeeCalculator.Schemas.Dbo.Parameter", "Parameter")
                        .WithMany("RuleDefParameterMappings")
                        .HasForeignKey("ParameterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TQ.Data.FeeCalculator.Schemas.Dbo.RuleDef", "RuleDef")
                        .WithMany("RuleDefParameterMappings")
                        .HasForeignKey("RuleDefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TQ.Data.FeeCalculator.Schemas.Dbo.Step", b =>
                {
                    b.HasOne("TQ.Data.FeeCalculator.Schemas.Dbo.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TQ.Data.FeeCalculator.Schemas.Dbo.RuleDef", "RuleDef")
                        .WithMany()
                        .HasForeignKey("RuleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
