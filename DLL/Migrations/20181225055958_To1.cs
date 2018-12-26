using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class To1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FLegalPersons",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ZUpdateTimestamp = table.Column<DateTime>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatePerson = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdatePerson = table.Column<string>(nullable: true),
                    Version = table.Column<DateTime>(nullable: true),
                    FEnterpriseName = table.Column<string>(maxLength: 200, nullable: true),
                    FRegistrationNumber = table.Column<string>(maxLength: 200, nullable: true),
                    FOrganizationalCode = table.Column<string>(maxLength: 200, nullable: true),
                    FTaxRegistrationNumber = table.Column<string>(maxLength: 200, nullable: true),
                    FIDNumber = table.Column<string>(maxLength: 200, nullable: true),
                    FResidence = table.Column<string>(maxLength: 200, nullable: true),
                    FRegisteredCapital = table.Column<string>(maxLength: 200, nullable: true),
                    FCurrency = table.Column<string>(maxLength: 200, nullable: true),
                    FForeignCurrency = table.Column<string>(maxLength: 200, nullable: true),
                    FTypesOfEnterprises = table.Column<string>(maxLength: 200, nullable: true),
                    FBusinessScope = table.Column<string>(maxLength: 200, nullable: true),
                    FBusinessTermTo = table.Column<string>(maxLength: 200, nullable: true),
                    FEstablishDate = table.Column<string>(maxLength: 200, nullable: true),
                    FSubjectionName = table.Column<string>(maxLength: 200, nullable: true),
                    FManagementState = table.Column<string>(maxLength: 200, nullable: true),
                    FCreditCode = table.Column<string>(maxLength: 200, nullable: true),
                    FDataSources = table.Column<string>(maxLength: 200, nullable: true),
                    FApprovalDate = table.Column<string>(maxLength: 200, nullable: true),
                    FIndustryCode = table.Column<string>(maxLength: 200, nullable: true),
                    FRegistrationAuthority = table.Column<string>(maxLength: 200, nullable: true),
                    FPlaceOfBusiness = table.Column<string>(maxLength: 200, nullable: true),
                    FBranchIdentification = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FLegalPersons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysExceptions",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 36, nullable: false),
                    LeiXing = table.Column<string>(maxLength: 200, nullable: true),
                    Message = table.Column<string>(maxLength: 2000, nullable: true),
                    Result = table.Column<string>(maxLength: 200, nullable: true),
                    Remarks = table.Column<string>(maxLength: 1000, nullable: true),
                    Sort = table.Column<int>(nullable: true),
                    State = table.Column<string>(maxLength: 200, nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatePerson = table.Column<string>(maxLength: 200, nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdatePerson = table.Column<string>(maxLength: 200, nullable: true),
                    Version = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysExceptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysLogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Application = table.Column<string>(maxLength: 50, nullable: false),
                    Logged = table.Column<DateTime>(nullable: false),
                    Level = table.Column<string>(maxLength: 50, nullable: false),
                    Message = table.Column<string>(nullable: false),
                    Logger = table.Column<string>(maxLength: 250, nullable: true),
                    Callsite = table.Column<string>(nullable: true),
                    Exception = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ZNaturalPersons",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ZUpdateTimestamp = table.Column<DateTime>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatePerson = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdatePerson = table.Column<string>(nullable: true),
                    Version = table.Column<DateTime>(nullable: true),
                    ZName = table.Column<string>(maxLength: 200, nullable: true),
                    ZDocumentType = table.Column<string>(maxLength: 200, nullable: true),
                    ZLdentificationNumber = table.Column<string>(maxLength: 200, nullable: true),
                    ZCompany = table.Column<string>(maxLength: 200, nullable: true),
                    ZPost = table.Column<string>(maxLength: 200, nullable: true),
                    ZDataSources = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZNaturalPersons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FAdministrativeCoercions",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ZUpdateTimestamp = table.Column<DateTime>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatePerson = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdatePerson = table.Column<string>(nullable: true),
                    Version = table.Column<DateTime>(nullable: true),
                    FBookNumber = table.Column<string>(maxLength: 200, nullable: true),
                    FEntryName = table.Column<string>(maxLength: 200, nullable: true),
                    FAdministrativeOrgan = table.Column<string>(maxLength: 200, nullable: true),
                    FMandatoryContent = table.Column<string>(maxLength: 200, nullable: true),
                    FExecutionDate = table.Column<string>(maxLength: 200, nullable: true),
                    FLegalPersonID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAdministrativeCoercions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FAdministrativeCoercions_FLegalPersons_FLegalPersonID",
                        column: x => x.FLegalPersonID,
                        principalTable: "FLegalPersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FAdministrativeExaminations",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ZUpdateTimestamp = table.Column<DateTime>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatePerson = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdatePerson = table.Column<string>(nullable: true),
                    Version = table.Column<DateTime>(nullable: true),
                    FBookNumber = table.Column<string>(maxLength: 200, nullable: true),
                    FInspectionReason = table.Column<string>(maxLength: 200, nullable: true),
                    FInspectionBasis = table.Column<string>(maxLength: 200, nullable: true),
                    FExaminationResult = table.Column<string>(maxLength: 200, nullable: true),
                    FInspectionOrgan = table.Column<string>(maxLength: 200, nullable: true),
                    FInspectionDate = table.Column<string>(maxLength: 200, nullable: true),
                    FCurrentState = table.Column<string>(maxLength: 200, nullable: true),
                    FLocalCoding = table.Column<string>(maxLength: 200, nullable: true),
                    FLegalPersonID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAdministrativeExaminations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FAdministrativeExaminations_FLegalPersons_FLegalPersonID",
                        column: x => x.FLegalPersonID,
                        principalTable: "FLegalPersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FAdministrativeLicensings",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ZUpdateTimestamp = table.Column<DateTime>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatePerson = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdatePerson = table.Column<string>(nullable: true),
                    Version = table.Column<DateTime>(nullable: true),
                    FBookNumber = table.Column<string>(maxLength: 200, nullable: true),
                    FEntryName = table.Column<string>(maxLength: 200, nullable: true),
                    FApprovalCategory = table.Column<string>(maxLength: 200, nullable: true),
                    FPermissionContent = table.Column<string>(maxLength: 200, nullable: true),
                    FEffectivePeriod = table.Column<string>(maxLength: 200, nullable: true),
                    FDeadline = table.Column<string>(maxLength: 200, nullable: true),
                    FLicensingAuthority = table.Column<string>(maxLength: 200, nullable: true),
                    FCurrentState = table.Column<string>(maxLength: 200, nullable: true),
                    FLocalCoding = table.Column<string>(maxLength: 200, nullable: true),
                    FLegalPersonID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAdministrativeLicensings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FAdministrativeLicensings_FLegalPersons_FLegalPersonID",
                        column: x => x.FLegalPersonID,
                        principalTable: "FLegalPersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FAdministrativeRewards",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ZUpdateTimestamp = table.Column<DateTime>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatePerson = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdatePerson = table.Column<string>(nullable: true),
                    Version = table.Column<DateTime>(nullable: true),
                    FHonoraryTitle = table.Column<string>(maxLength: 200, nullable: true),
                    FCommendationUnit = table.Column<string>(maxLength: 200, nullable: true),
                    FCommendationDate = table.Column<string>(maxLength: 200, nullable: true),
                    FCommendationSymbol = table.Column<string>(maxLength: 200, nullable: true),
                    FLegalPersonID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAdministrativeRewards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FAdministrativeRewards_FLegalPersons_FLegalPersonID",
                        column: x => x.FLegalPersonID,
                        principalTable: "FLegalPersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FAdministrativeSanctions",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ZUpdateTimestamp = table.Column<DateTime>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatePerson = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdatePerson = table.Column<string>(nullable: true),
                    Version = table.Column<DateTime>(nullable: true),
                    FBookNumber = table.Column<string>(maxLength: 200, nullable: true),
                    FNameOfCase = table.Column<string>(maxLength: 200, nullable: true),
                    FPunishmentCategory = table.Column<string>(maxLength: 200, nullable: true),
                    FPunishmentCause = table.Column<string>(maxLength: 200, nullable: true),
                    FPunishmentBasis = table.Column<string>(maxLength: 200, nullable: true),
                    FEffectivePeriod = table.Column<string>(maxLength: 200, nullable: true),
                    FDeadline = table.Column<string>(maxLength: 200, nullable: true),
                    FPunishmentOrgan = table.Column<string>(maxLength: 200, nullable: true),
                    FPenaltyResult = table.Column<string>(maxLength: 200, nullable: true),
                    FCurrentState = table.Column<string>(maxLength: 200, nullable: true),
                    FLocalCoding = table.Column<string>(maxLength: 200, nullable: true),
                    FLegalPersonID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAdministrativeSanctions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FAdministrativeSanctions_FLegalPersons_FLegalPersonID",
                        column: x => x.FLegalPersonID,
                        principalTable: "FLegalPersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FDishonestExecutors",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ZUpdateTimestamp = table.Column<DateTime>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatePerson = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdatePerson = table.Column<string>(nullable: true),
                    Version = table.Column<DateTime>(nullable: true),
                    FEnforcementNumber = table.Column<string>(maxLength: 200, nullable: true),
                    FCourtOfExecution = table.Column<string>(maxLength: 200, nullable: true),
                    FFilingDate = table.Column<string>(maxLength: 200, nullable: true),
                    FCaseStatus = table.Column<string>(maxLength: 200, nullable: true),
                    FExecutionNumber = table.Column<string>(maxLength: 200, nullable: true),
                    FEnforcementCase = table.Column<string>(maxLength: 200, nullable: true),
                    FDefiniteObligations = table.Column<string>(type: "ntext", nullable: true),
                    FPerformance = table.Column<string>(maxLength: 200, nullable: true),
                    BreachOfFaith = table.Column<string>(maxLength: 200, nullable: true),
                    ReleaseTime = table.Column<string>(maxLength: 200, nullable: true),
                    FLegalPersonID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FDishonestExecutors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FDishonestExecutors_FLegalPersons_FLegalPersonID",
                        column: x => x.FLegalPersonID,
                        principalTable: "FLegalPersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FOtherCommendations",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ZUpdateTimestamp = table.Column<DateTime>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatePerson = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdatePerson = table.Column<string>(nullable: true),
                    Version = table.Column<DateTime>(nullable: true),
                    FHonoraryTitle = table.Column<string>(maxLength: 200, nullable: true),
                    FCommendationUnit = table.Column<string>(maxLength: 200, nullable: true),
                    FCommendationDate = table.Column<string>(maxLength: 200, nullable: true),
                    FCommendationSymbol = table.Column<string>(maxLength: 200, nullable: true),
                    FLegalPersonID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FOtherCommendations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FOtherCommendations_FLegalPersons_FLegalPersonID",
                        column: x => x.FLegalPersonID,
                        principalTable: "FLegalPersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FOtherPenaltiess",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ZUpdateTimestamp = table.Column<DateTime>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatePerson = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdatePerson = table.Column<string>(nullable: true),
                    Version = table.Column<DateTime>(nullable: true),
                    FNameOfCase = table.Column<string>(maxLength: 200, nullable: true),
                    FPunishmentCategory = table.Column<string>(maxLength: 200, nullable: true),
                    FPunishmentCause = table.Column<string>(maxLength: 200, nullable: true),
                    FPunishmentBasis = table.Column<string>(maxLength: 200, nullable: true),
                    FEffectivePeriod = table.Column<string>(maxLength: 200, nullable: true),
                    FDeadline = table.Column<string>(maxLength: 200, nullable: true),
                    FPunishmentOrgan = table.Column<string>(maxLength: 200, nullable: true),
                    FPenaltyResult = table.Column<string>(maxLength: 200, nullable: true),
                    FCurrentState = table.Column<string>(maxLength: 200, nullable: true),
                    FLocalCoding = table.Column<string>(maxLength: 200, nullable: true),
                    FLegalPersonID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FOtherPenaltiess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FOtherPenaltiess_FLegalPersons_FLegalPersonID",
                        column: x => x.FLegalPersonID,
                        principalTable: "FLegalPersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZAdministrativeCoercions",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ZUpdateTimestamp = table.Column<DateTime>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatePerson = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdatePerson = table.Column<string>(nullable: true),
                    Version = table.Column<DateTime>(nullable: true),
                    ZBookNumber = table.Column<string>(maxLength: 200, nullable: true),
                    ZEntryName = table.Column<string>(maxLength: 200, nullable: true),
                    ZAdministrativeOrgan = table.Column<string>(maxLength: 200, nullable: true),
                    ZMandatoryContent = table.Column<string>(maxLength: 200, nullable: true),
                    ZExecutionDate = table.Column<string>(maxLength: 200, nullable: true),
                    ZNaturalPersonID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZAdministrativeCoercions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ZAdministrativeCoercions_ZNaturalPersons_ZNaturalPersonID",
                        column: x => x.ZNaturalPersonID,
                        principalTable: "ZNaturalPersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZAdministrativeLicensings",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ZUpdateTimestamp = table.Column<DateTime>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatePerson = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdatePerson = table.Column<string>(nullable: true),
                    Version = table.Column<DateTime>(nullable: true),
                    ZBookNumber = table.Column<string>(maxLength: 200, nullable: true),
                    ZEntryName = table.Column<string>(maxLength: 200, nullable: true),
                    ZApprovalCategory = table.Column<string>(maxLength: 200, nullable: true),
                    ZPermissionContent = table.Column<string>(maxLength: 200, nullable: true),
                    ZEffectivePeriod = table.Column<string>(maxLength: 200, nullable: true),
                    ZDeadline = table.Column<string>(maxLength: 200, nullable: true),
                    ZLicensingAuthority = table.Column<string>(maxLength: 200, nullable: true),
                    ZCurrentState = table.Column<string>(maxLength: 200, nullable: true),
                    ZLocalCoding = table.Column<string>(maxLength: 200, nullable: true),
                    ZNaturalPersonID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZAdministrativeLicensings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ZAdministrativeLicensings_ZNaturalPersons_ZNaturalPersonID",
                        column: x => x.ZNaturalPersonID,
                        principalTable: "ZNaturalPersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZAdministrativeRewards",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ZUpdateTimestamp = table.Column<DateTime>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatePerson = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdatePerson = table.Column<string>(nullable: true),
                    Version = table.Column<DateTime>(nullable: true),
                    ZHonoraryTitle = table.Column<string>(maxLength: 200, nullable: true),
                    ZCommendationUnit = table.Column<string>(maxLength: 200, nullable: true),
                    ZCommendationDate = table.Column<string>(maxLength: 200, nullable: true),
                    ZCommendationSymbol = table.Column<string>(maxLength: 200, nullable: true),
                    ZNaturalPersonID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZAdministrativeRewards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ZAdministrativeRewards_ZNaturalPersons_ZNaturalPersonID",
                        column: x => x.ZNaturalPersonID,
                        principalTable: "ZNaturalPersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZAdministrativeSanctions",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ZUpdateTimestamp = table.Column<DateTime>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatePerson = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdatePerson = table.Column<string>(nullable: true),
                    Version = table.Column<DateTime>(nullable: true),
                    ZBookNumber = table.Column<string>(maxLength: 200, nullable: true),
                    ZNameOfCase = table.Column<string>(maxLength: 200, nullable: true),
                    ZPunishmentCategory = table.Column<string>(maxLength: 200, nullable: true),
                    ZPunishmentCause = table.Column<string>(maxLength: 200, nullable: true),
                    ZPunishmentBasis = table.Column<string>(maxLength: 200, nullable: true),
                    ZEffectivePeriod = table.Column<string>(maxLength: 200, nullable: true),
                    ZDeadline = table.Column<string>(maxLength: 200, nullable: true),
                    ZPunishmentOrgan = table.Column<string>(maxLength: 200, nullable: true),
                    ZPenaltyResult = table.Column<string>(maxLength: 200, nullable: true),
                    ZCurrentState = table.Column<string>(maxLength: 200, nullable: true),
                    ZLocalCoding = table.Column<string>(maxLength: 200, nullable: true),
                    ZNaturalPersonID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZAdministrativeSanctions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ZAdministrativeSanctions_ZNaturalPersons_ZNaturalPersonID",
                        column: x => x.ZNaturalPersonID,
                        principalTable: "ZNaturalPersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZDishonestExecutors",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ZUpdateTimestamp = table.Column<DateTime>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatePerson = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdatePerson = table.Column<string>(nullable: true),
                    Version = table.Column<DateTime>(nullable: true),
                    ZEnforcementNumber = table.Column<string>(maxLength: 200, nullable: true),
                    ZCourtOfExecution = table.Column<string>(maxLength: 200, nullable: true),
                    ZFilingDate = table.Column<string>(maxLength: 200, nullable: true),
                    ZCaseStatus = table.Column<string>(maxLength: 200, nullable: true),
                    ZExecutionNumber = table.Column<string>(maxLength: 200, nullable: true),
                    ZEnforcementCase = table.Column<string>(maxLength: 200, nullable: true),
                    ZDefiniteObligations = table.Column<string>(type: "ntext", nullable: true),
                    ZPerformance = table.Column<string>(maxLength: 200, nullable: true),
                    BreachOfFaith = table.Column<string>(maxLength: 200, nullable: true),
                    ReleaseTime = table.Column<string>(maxLength: 200, nullable: true),
                    ZNaturalPersonID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZDishonestExecutors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ZDishonestExecutors_ZNaturalPersons_ZNaturalPersonID",
                        column: x => x.ZNaturalPersonID,
                        principalTable: "ZNaturalPersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZOtherCommendations",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ZUpdateTimestamp = table.Column<DateTime>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatePerson = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdatePerson = table.Column<string>(nullable: true),
                    Version = table.Column<DateTime>(nullable: true),
                    ZHonoraryTitle = table.Column<string>(maxLength: 200, nullable: true),
                    ZCommendationUnit = table.Column<string>(maxLength: 200, nullable: true),
                    ZCommendationDate = table.Column<string>(maxLength: 200, nullable: true),
                    ZCommendationSymbol = table.Column<string>(maxLength: 200, nullable: true),
                    ZNaturalPersonID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZOtherCommendations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ZOtherCommendations_ZNaturalPersons_ZNaturalPersonID",
                        column: x => x.ZNaturalPersonID,
                        principalTable: "ZNaturalPersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZOtherPenaltiess",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ZUpdateTimestamp = table.Column<DateTime>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreatePerson = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdatePerson = table.Column<string>(nullable: true),
                    Version = table.Column<DateTime>(nullable: true),
                    ZNameOfCase = table.Column<string>(maxLength: 200, nullable: true),
                    ZPunishmentCategory = table.Column<string>(maxLength: 200, nullable: true),
                    ZPunishmentCause = table.Column<string>(maxLength: 200, nullable: true),
                    ZPunishmentBasis = table.Column<string>(maxLength: 200, nullable: true),
                    ZEffectivePeriod = table.Column<string>(maxLength: 200, nullable: true),
                    ZPunishmentOrgan = table.Column<string>(maxLength: 200, nullable: true),
                    ZPenaltyResult = table.Column<string>(maxLength: 200, nullable: true),
                    ZCurrentState = table.Column<string>(maxLength: 200, nullable: true),
                    ZLocalCoding = table.Column<string>(maxLength: 200, nullable: true),
                    ZNaturalPersonID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZOtherPenaltiess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ZOtherPenaltiess_ZNaturalPersons_ZNaturalPersonID",
                        column: x => x.ZNaturalPersonID,
                        principalTable: "ZNaturalPersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FAdministrativeCoercions_FLegalPersonID",
                table: "FAdministrativeCoercions",
                column: "FLegalPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_FAdministrativeExaminations_FLegalPersonID",
                table: "FAdministrativeExaminations",
                column: "FLegalPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_FAdministrativeLicensings_FLegalPersonID",
                table: "FAdministrativeLicensings",
                column: "FLegalPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_FAdministrativeRewards_FLegalPersonID",
                table: "FAdministrativeRewards",
                column: "FLegalPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_FAdministrativeSanctions_FLegalPersonID",
                table: "FAdministrativeSanctions",
                column: "FLegalPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_FDishonestExecutors_FLegalPersonID",
                table: "FDishonestExecutors",
                column: "FLegalPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_FOtherCommendations_FLegalPersonID",
                table: "FOtherCommendations",
                column: "FLegalPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_FOtherPenaltiess_FLegalPersonID",
                table: "FOtherPenaltiess",
                column: "FLegalPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_ZAdministrativeCoercions_ZNaturalPersonID",
                table: "ZAdministrativeCoercions",
                column: "ZNaturalPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_ZAdministrativeLicensings_ZNaturalPersonID",
                table: "ZAdministrativeLicensings",
                column: "ZNaturalPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_ZAdministrativeRewards_ZNaturalPersonID",
                table: "ZAdministrativeRewards",
                column: "ZNaturalPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_ZAdministrativeSanctions_ZNaturalPersonID",
                table: "ZAdministrativeSanctions",
                column: "ZNaturalPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_ZDishonestExecutors_ZNaturalPersonID",
                table: "ZDishonestExecutors",
                column: "ZNaturalPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_ZOtherCommendations_ZNaturalPersonID",
                table: "ZOtherCommendations",
                column: "ZNaturalPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_ZOtherPenaltiess_ZNaturalPersonID",
                table: "ZOtherPenaltiess",
                column: "ZNaturalPersonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FAdministrativeCoercions");

            migrationBuilder.DropTable(
                name: "FAdministrativeExaminations");

            migrationBuilder.DropTable(
                name: "FAdministrativeLicensings");

            migrationBuilder.DropTable(
                name: "FAdministrativeRewards");

            migrationBuilder.DropTable(
                name: "FAdministrativeSanctions");

            migrationBuilder.DropTable(
                name: "FDishonestExecutors");

            migrationBuilder.DropTable(
                name: "FOtherCommendations");

            migrationBuilder.DropTable(
                name: "FOtherPenaltiess");

            migrationBuilder.DropTable(
                name: "SysExceptions");

            migrationBuilder.DropTable(
                name: "SysLogs");

            migrationBuilder.DropTable(
                name: "ZAdministrativeCoercions");

            migrationBuilder.DropTable(
                name: "ZAdministrativeLicensings");

            migrationBuilder.DropTable(
                name: "ZAdministrativeRewards");

            migrationBuilder.DropTable(
                name: "ZAdministrativeSanctions");

            migrationBuilder.DropTable(
                name: "ZDishonestExecutors");

            migrationBuilder.DropTable(
                name: "ZOtherCommendations");

            migrationBuilder.DropTable(
                name: "ZOtherPenaltiess");

            migrationBuilder.DropTable(
                name: "FLegalPersons");

            migrationBuilder.DropTable(
                name: "ZNaturalPersons");
        }
    }
}
