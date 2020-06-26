﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TQ.Data.PlanningPortal;

namespace TQ.Data.PlanningPortal.Migrations
{
    [DbContext(typeof(PlanningPortalContext))]
    [Migration("20200219063355_#909-InitialSetup")]
    partial class _909InitialSetup
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.Dbo.Answer", b =>
                {
                    b.Property<Guid>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ParameterAnswer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParameterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SessionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SessionType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnswerId");

                    b.ToTable("Answers","dbo");
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.Dbo.ApplicationType", b =>
                {
                    b.Property<Guid>("ApplicationTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReferenceId")
                        .HasColumnType("int");

                    b.HasKey("ApplicationTypeId");

                    b.HasIndex("ReferenceId")
                        .IsUnique();

                    b.ToTable("ApplicationTypes","dbo");
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.Dbo.ParamDataType", b =>
                {
                    b.Property<Guid>("ParamDataTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ParamDataTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ParamDataTypeId");

                    b.ToTable("ParamDataTypes","dbo");
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.Dbo.Parameter", b =>
                {
                    b.Property<Guid>("ParameterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ParamDataTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ParameterId");

                    b.HasIndex("ParamDataTypeId");

                    b.ToTable("Parameters","dbo");
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.Dbo.Qsr", b =>
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

                    b.ToTable("Qsr","dbo");
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.Dbo.QuestionSetResponse", b =>
                {
                    b.Property<Guid>("QuestionSetResponseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("LastSaved")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("QuestionSetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Response")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserApplicationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("QuestionSetResponseId");

                    b.ToTable("QuestionSetResponses","dbo");
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.Dbo.Region", b =>
                {
                    b.Property<Guid>("RegionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RegionTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RegionId");

                    b.HasIndex("RegionTypeId");

                    b.ToTable("Regions","dbo");
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.Dbo.RegionTypes", b =>
                {
                    b.Property<Guid>("RegionTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RegionType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RegionTypeId");

                    b.ToTable("RegionTypes","dbo");
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.Dbo.RuleDef", b =>
                {
                    b.Property<Guid>("RuleDefId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DefPackageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReferenceId")
                        .HasColumnType("int");

                    b.Property<Guid>("RegionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RuleDefinition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RuleDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RuleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SequenceNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("RuleDefId");

                    b.HasIndex("RegionId");

                    b.HasIndex("DefPackageId", "ReferenceId")
                        .IsUnique();

                    b.ToTable("RuleDefs","dbo");
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.Dbo.RuleDefParameterMapping", b =>
                {
                    b.Property<Guid>("RuleDefParameterMappingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsFinalOutput")
                        .HasColumnType("bit");

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

                    b.ToTable("RuleDefParameterMappings","dbo");
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.Dbo.RuleQuestion", b =>
                {
                    b.Property<Guid>("RuleQuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Datatype")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RuleDefId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RuleQuestionId");

                    b.HasIndex("RuleDefId");

                    b.ToTable("RuleQuestions","dbo");
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.Dbo.UserApplication", b =>
                {
                    b.Property<Guid>("UserApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ApplicationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastSaved")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PlanningFormId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Started")
                        .HasColumnType("bit");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserApplicationId");

                    b.ToTable("UserApplications","dbo");
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.FeeCalc.Audit", b =>
                {
                    b.Property<Guid>("AuditId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PackageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TestHeader")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuditId");

                    b.ToTable("Audits","feecalc");
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.FeeCalc.DefPackage", b =>
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

                    b.Property<int?>("Version")
                        .HasColumnType("int");

                    b.HasKey("DefPackageId");

                    b.ToTable("DefPackages","feecalc");
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.FeeCalc.Definition", b =>
                {
                    b.Property<Guid>("DefinitionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApplicationTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CalculationDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DefPackageId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DefinitionId");

                    b.HasIndex("ApplicationTypeId");

                    b.HasIndex("DefPackageId");

                    b.ToTable("Definitions","feecalc");
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.FeeCalc.DefsRuleDefMapping", b =>
                {
                    b.Property<Guid>("DefsRuleDefMappingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DefinitionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RuleDefId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DefsRuleDefMappingId");

                    b.HasIndex("DefinitionId");

                    b.HasIndex("RuleDefId");

                    b.ToTable("DefsRuleDefMapping","feecalc");
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.FeeCalc.Session", b =>
                {
                    b.Property<Guid>("SessionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CalculationInputs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CalculationOutputs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DefinitionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlanningApplicationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SessionId");

                    b.HasIndex("DefinitionId");

                    b.ToTable("Sessions","feecalc");
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.FeeCalc.Step", b =>
                {
                    b.Property<Guid>("StepId")
                        .ValueGeneratedOnAdd()
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

                    b.HasIndex("RuleId");

                    b.ToTable("Steps","feecalc");
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.FeeCalc.TestHeader", b =>
                {
                    b.Property<Guid>("TestHeaderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CalculationDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DefPackageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TestSuccess")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TestHeaderId");

                    b.HasIndex("DefPackageId");

                    b.ToTable("TestHeaders","feecalc");
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.FeeCalc.TestLine", b =>
                {
                    b.Property<Guid>("TestLineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Actual")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CalculationData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Expected")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TestSetHeaderId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TestLineId");

                    b.HasIndex("TestSetHeaderId");

                    b.ToTable("TestLines","feecalc");
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.FeeCalc.TestSetHeader", b =>
                {
                    b.Property<Guid>("TestSetHeaderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImportFileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TestSetLineId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TestSetHeaderId");

                    b.HasIndex("TestSetLineId");

                    b.ToTable("TestSetHeaders","feecalc");
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.FeeCalc.TestSetLine", b =>
                {
                    b.Property<Guid>("TestSetLineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CalculationData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DefinitionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Expected")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TestLineId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TestSetLineId");

                    b.HasIndex("DefinitionId");

                    b.HasIndex("TestLineId");

                    b.ToTable("TestSetLines","feecalc");
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.Dbo.Parameter", b =>
                {
                    b.HasOne("TQ.Data.PlanningPortal.Schemas.Dbo.ParamDataType", "ParamDataType")
                        .WithMany()
                        .HasForeignKey("ParamDataTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.Dbo.Region", b =>
                {
                    b.HasOne("TQ.Data.PlanningPortal.Schemas.Dbo.RegionTypes", "RegionType")
                        .WithMany()
                        .HasForeignKey("RegionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.Dbo.RuleDef", b =>
                {
                    b.HasOne("TQ.Data.PlanningPortal.Schemas.FeeCalc.DefPackage", "DefPackage")
                        .WithMany()
                        .HasForeignKey("DefPackageId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TQ.Data.PlanningPortal.Schemas.Dbo.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.Dbo.RuleDefParameterMapping", b =>
                {
                    b.HasOne("TQ.Data.PlanningPortal.Schemas.Dbo.Parameter", "Parameter")
                        .WithMany("RuleDefParameterMappings")
                        .HasForeignKey("ParameterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TQ.Data.PlanningPortal.Schemas.Dbo.RuleDef", "RuleDef")
                        .WithMany("RuleDefParameterMappings")
                        .HasForeignKey("RuleDefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.Dbo.RuleQuestion", b =>
                {
                    b.HasOne("TQ.Data.PlanningPortal.Schemas.Dbo.RuleDef", "RuleDef")
                        .WithMany()
                        .HasForeignKey("RuleDefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.FeeCalc.Definition", b =>
                {
                    b.HasOne("TQ.Data.PlanningPortal.Schemas.Dbo.ApplicationType", "ApplicationType")
                        .WithMany()
                        .HasForeignKey("ApplicationTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TQ.Data.PlanningPortal.Schemas.FeeCalc.DefPackage", "DefPackage")
                        .WithMany()
                        .HasForeignKey("DefPackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.FeeCalc.DefsRuleDefMapping", b =>
                {
                    b.HasOne("TQ.Data.PlanningPortal.Schemas.FeeCalc.Definition", "Definition")
                        .WithMany("DefsRuleDefMappings")
                        .HasForeignKey("DefinitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TQ.Data.PlanningPortal.Schemas.Dbo.RuleDef", "RuleDef")
                        .WithMany("FeeCalculatorDefsRuleDefMappings")
                        .HasForeignKey("RuleDefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.FeeCalc.Session", b =>
                {
                    b.HasOne("TQ.Data.PlanningPortal.Schemas.FeeCalc.Definition", "Definition")
                        .WithMany()
                        .HasForeignKey("DefinitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.FeeCalc.Step", b =>
                {
                    b.HasOne("TQ.Data.PlanningPortal.Schemas.Dbo.RuleDef", "Rule")
                        .WithMany()
                        .HasForeignKey("RuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.FeeCalc.TestHeader", b =>
                {
                    b.HasOne("TQ.Data.PlanningPortal.Schemas.FeeCalc.DefPackage", "DefPackage")
                        .WithMany()
                        .HasForeignKey("DefPackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.FeeCalc.TestLine", b =>
                {
                    b.HasOne("TQ.Data.PlanningPortal.Schemas.FeeCalc.TestSetHeader", "TestSetHeader")
                        .WithMany()
                        .HasForeignKey("TestSetHeaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.FeeCalc.TestSetHeader", b =>
                {
                    b.HasOne("TQ.Data.PlanningPortal.Schemas.FeeCalc.TestSetLine", "TestSetLine")
                        .WithMany()
                        .HasForeignKey("TestSetLineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TQ.Data.PlanningPortal.Schemas.FeeCalc.TestSetLine", b =>
                {
                    b.HasOne("TQ.Data.PlanningPortal.Schemas.FeeCalc.Definition", "Definition")
                        .WithMany()
                        .HasForeignKey("DefinitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TQ.Data.PlanningPortal.Schemas.FeeCalc.TestLine", "TestLine")
                        .WithMany()
                        .HasForeignKey("TestLineId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
