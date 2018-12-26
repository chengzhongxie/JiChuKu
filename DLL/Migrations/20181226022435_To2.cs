using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class To2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FAdministrativeCoercions_FLegalPersons_FLegalPersonID",
                table: "FAdministrativeCoercions");

            migrationBuilder.DropForeignKey(
                name: "FK_FAdministrativeExaminations_FLegalPersons_FLegalPersonID",
                table: "FAdministrativeExaminations");

            migrationBuilder.DropForeignKey(
                name: "FK_FAdministrativeLicensings_FLegalPersons_FLegalPersonID",
                table: "FAdministrativeLicensings");

            migrationBuilder.DropForeignKey(
                name: "FK_FAdministrativeRewards_FLegalPersons_FLegalPersonID",
                table: "FAdministrativeRewards");

            migrationBuilder.DropForeignKey(
                name: "FK_FAdministrativeSanctions_FLegalPersons_FLegalPersonID",
                table: "FAdministrativeSanctions");

            migrationBuilder.DropForeignKey(
                name: "FK_FDishonestExecutors_FLegalPersons_FLegalPersonID",
                table: "FDishonestExecutors");

            migrationBuilder.DropForeignKey(
                name: "FK_FOtherCommendations_FLegalPersons_FLegalPersonID",
                table: "FOtherCommendations");

            migrationBuilder.DropForeignKey(
                name: "FK_FOtherPenaltiess_FLegalPersons_FLegalPersonID",
                table: "FOtherPenaltiess");

            migrationBuilder.DropForeignKey(
                name: "FK_ZAdministrativeCoercions_ZNaturalPersons_ZNaturalPersonID",
                table: "ZAdministrativeCoercions");

            migrationBuilder.DropForeignKey(
                name: "FK_ZAdministrativeLicensings_ZNaturalPersons_ZNaturalPersonID",
                table: "ZAdministrativeLicensings");

            migrationBuilder.DropForeignKey(
                name: "FK_ZAdministrativeRewards_ZNaturalPersons_ZNaturalPersonID",
                table: "ZAdministrativeRewards");

            migrationBuilder.DropForeignKey(
                name: "FK_ZAdministrativeSanctions_ZNaturalPersons_ZNaturalPersonID",
                table: "ZAdministrativeSanctions");

            migrationBuilder.DropForeignKey(
                name: "FK_ZDishonestExecutors_ZNaturalPersons_ZNaturalPersonID",
                table: "ZDishonestExecutors");

            migrationBuilder.DropForeignKey(
                name: "FK_ZOtherCommendations_ZNaturalPersons_ZNaturalPersonID",
                table: "ZOtherCommendations");

            migrationBuilder.DropForeignKey(
                name: "FK_ZOtherPenaltiess_ZNaturalPersons_ZNaturalPersonID",
                table: "ZOtherPenaltiess");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZOtherPenaltiess",
                table: "ZOtherPenaltiess");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZOtherCommendations",
                table: "ZOtherCommendations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZNaturalPersons",
                table: "ZNaturalPersons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZDishonestExecutors",
                table: "ZDishonestExecutors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZAdministrativeSanctions",
                table: "ZAdministrativeSanctions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZAdministrativeRewards",
                table: "ZAdministrativeRewards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZAdministrativeLicensings",
                table: "ZAdministrativeLicensings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZAdministrativeCoercions",
                table: "ZAdministrativeCoercions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SysLogs",
                table: "SysLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SysExceptions",
                table: "SysExceptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FOtherPenaltiess",
                table: "FOtherPenaltiess");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FOtherCommendations",
                table: "FOtherCommendations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FLegalPersons",
                table: "FLegalPersons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FDishonestExecutors",
                table: "FDishonestExecutors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FAdministrativeSanctions",
                table: "FAdministrativeSanctions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FAdministrativeRewards",
                table: "FAdministrativeRewards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FAdministrativeLicensings",
                table: "FAdministrativeLicensings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FAdministrativeExaminations",
                table: "FAdministrativeExaminations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FAdministrativeCoercions",
                table: "FAdministrativeCoercions");

            migrationBuilder.RenameTable(
                name: "ZOtherPenaltiess",
                newName: "ZOtherPenalties");

            migrationBuilder.RenameTable(
                name: "ZOtherCommendations",
                newName: "ZOtherCommendation");

            migrationBuilder.RenameTable(
                name: "ZNaturalPersons",
                newName: "ZNaturalPerson");

            migrationBuilder.RenameTable(
                name: "ZDishonestExecutors",
                newName: "ZDishonestExecutor");

            migrationBuilder.RenameTable(
                name: "ZAdministrativeSanctions",
                newName: "ZAdministrativeSanction");

            migrationBuilder.RenameTable(
                name: "ZAdministrativeRewards",
                newName: "ZAdministrativeReward");

            migrationBuilder.RenameTable(
                name: "ZAdministrativeLicensings",
                newName: "ZAdministrativeLicensing");

            migrationBuilder.RenameTable(
                name: "ZAdministrativeCoercions",
                newName: "ZAdministrativeCoercion");

            migrationBuilder.RenameTable(
                name: "SysLogs",
                newName: "SysLog");

            migrationBuilder.RenameTable(
                name: "SysExceptions",
                newName: "SysException");

            migrationBuilder.RenameTable(
                name: "FOtherPenaltiess",
                newName: "FOtherPenalties");

            migrationBuilder.RenameTable(
                name: "FOtherCommendations",
                newName: "FOtherCommendation");

            migrationBuilder.RenameTable(
                name: "FLegalPersons",
                newName: "FLegalPerson");

            migrationBuilder.RenameTable(
                name: "FDishonestExecutors",
                newName: "FDishonestExecutor");

            migrationBuilder.RenameTable(
                name: "FAdministrativeSanctions",
                newName: "FAdministrativeSanction");

            migrationBuilder.RenameTable(
                name: "FAdministrativeRewards",
                newName: "FAdministrativeReward");

            migrationBuilder.RenameTable(
                name: "FAdministrativeLicensings",
                newName: "FAdministrativeLicensing");

            migrationBuilder.RenameTable(
                name: "FAdministrativeExaminations",
                newName: "FAdministrativeExamination");

            migrationBuilder.RenameTable(
                name: "FAdministrativeCoercions",
                newName: "FAdministrativeCoercion");

            migrationBuilder.RenameIndex(
                name: "IX_ZOtherPenaltiess_ZNaturalPersonID",
                table: "ZOtherPenalties",
                newName: "IX_ZOtherPenalties_ZNaturalPersonID");

            migrationBuilder.RenameIndex(
                name: "IX_ZOtherCommendations_ZNaturalPersonID",
                table: "ZOtherCommendation",
                newName: "IX_ZOtherCommendation_ZNaturalPersonID");

            migrationBuilder.RenameIndex(
                name: "IX_ZDishonestExecutors_ZNaturalPersonID",
                table: "ZDishonestExecutor",
                newName: "IX_ZDishonestExecutor_ZNaturalPersonID");

            migrationBuilder.RenameIndex(
                name: "IX_ZAdministrativeSanctions_ZNaturalPersonID",
                table: "ZAdministrativeSanction",
                newName: "IX_ZAdministrativeSanction_ZNaturalPersonID");

            migrationBuilder.RenameIndex(
                name: "IX_ZAdministrativeRewards_ZNaturalPersonID",
                table: "ZAdministrativeReward",
                newName: "IX_ZAdministrativeReward_ZNaturalPersonID");

            migrationBuilder.RenameIndex(
                name: "IX_ZAdministrativeLicensings_ZNaturalPersonID",
                table: "ZAdministrativeLicensing",
                newName: "IX_ZAdministrativeLicensing_ZNaturalPersonID");

            migrationBuilder.RenameIndex(
                name: "IX_ZAdministrativeCoercions_ZNaturalPersonID",
                table: "ZAdministrativeCoercion",
                newName: "IX_ZAdministrativeCoercion_ZNaturalPersonID");

            migrationBuilder.RenameIndex(
                name: "IX_FOtherPenaltiess_FLegalPersonID",
                table: "FOtherPenalties",
                newName: "IX_FOtherPenalties_FLegalPersonID");

            migrationBuilder.RenameIndex(
                name: "IX_FOtherCommendations_FLegalPersonID",
                table: "FOtherCommendation",
                newName: "IX_FOtherCommendation_FLegalPersonID");

            migrationBuilder.RenameIndex(
                name: "IX_FDishonestExecutors_FLegalPersonID",
                table: "FDishonestExecutor",
                newName: "IX_FDishonestExecutor_FLegalPersonID");

            migrationBuilder.RenameIndex(
                name: "IX_FAdministrativeSanctions_FLegalPersonID",
                table: "FAdministrativeSanction",
                newName: "IX_FAdministrativeSanction_FLegalPersonID");

            migrationBuilder.RenameIndex(
                name: "IX_FAdministrativeRewards_FLegalPersonID",
                table: "FAdministrativeReward",
                newName: "IX_FAdministrativeReward_FLegalPersonID");

            migrationBuilder.RenameIndex(
                name: "IX_FAdministrativeLicensings_FLegalPersonID",
                table: "FAdministrativeLicensing",
                newName: "IX_FAdministrativeLicensing_FLegalPersonID");

            migrationBuilder.RenameIndex(
                name: "IX_FAdministrativeExaminations_FLegalPersonID",
                table: "FAdministrativeExamination",
                newName: "IX_FAdministrativeExamination_FLegalPersonID");

            migrationBuilder.RenameIndex(
                name: "IX_FAdministrativeCoercions_FLegalPersonID",
                table: "FAdministrativeCoercion",
                newName: "IX_FAdministrativeCoercion_FLegalPersonID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZOtherPenalties",
                table: "ZOtherPenalties",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZOtherCommendation",
                table: "ZOtherCommendation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZNaturalPerson",
                table: "ZNaturalPerson",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZDishonestExecutor",
                table: "ZDishonestExecutor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZAdministrativeSanction",
                table: "ZAdministrativeSanction",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZAdministrativeReward",
                table: "ZAdministrativeReward",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZAdministrativeLicensing",
                table: "ZAdministrativeLicensing",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZAdministrativeCoercion",
                table: "ZAdministrativeCoercion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SysLog",
                table: "SysLog",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SysException",
                table: "SysException",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FOtherPenalties",
                table: "FOtherPenalties",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FOtherCommendation",
                table: "FOtherCommendation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FLegalPerson",
                table: "FLegalPerson",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FDishonestExecutor",
                table: "FDishonestExecutor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FAdministrativeSanction",
                table: "FAdministrativeSanction",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FAdministrativeReward",
                table: "FAdministrativeReward",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FAdministrativeLicensing",
                table: "FAdministrativeLicensing",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FAdministrativeExamination",
                table: "FAdministrativeExamination",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FAdministrativeCoercion",
                table: "FAdministrativeCoercion",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FAdministrativeCoercion_FLegalPerson_FLegalPersonID",
                table: "FAdministrativeCoercion",
                column: "FLegalPersonID",
                principalTable: "FLegalPerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FAdministrativeExamination_FLegalPerson_FLegalPersonID",
                table: "FAdministrativeExamination",
                column: "FLegalPersonID",
                principalTable: "FLegalPerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FAdministrativeLicensing_FLegalPerson_FLegalPersonID",
                table: "FAdministrativeLicensing",
                column: "FLegalPersonID",
                principalTable: "FLegalPerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FAdministrativeReward_FLegalPerson_FLegalPersonID",
                table: "FAdministrativeReward",
                column: "FLegalPersonID",
                principalTable: "FLegalPerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FAdministrativeSanction_FLegalPerson_FLegalPersonID",
                table: "FAdministrativeSanction",
                column: "FLegalPersonID",
                principalTable: "FLegalPerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FDishonestExecutor_FLegalPerson_FLegalPersonID",
                table: "FDishonestExecutor",
                column: "FLegalPersonID",
                principalTable: "FLegalPerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FOtherCommendation_FLegalPerson_FLegalPersonID",
                table: "FOtherCommendation",
                column: "FLegalPersonID",
                principalTable: "FLegalPerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FOtherPenalties_FLegalPerson_FLegalPersonID",
                table: "FOtherPenalties",
                column: "FLegalPersonID",
                principalTable: "FLegalPerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZAdministrativeCoercion_ZNaturalPerson_ZNaturalPersonID",
                table: "ZAdministrativeCoercion",
                column: "ZNaturalPersonID",
                principalTable: "ZNaturalPerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZAdministrativeLicensing_ZNaturalPerson_ZNaturalPersonID",
                table: "ZAdministrativeLicensing",
                column: "ZNaturalPersonID",
                principalTable: "ZNaturalPerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZAdministrativeReward_ZNaturalPerson_ZNaturalPersonID",
                table: "ZAdministrativeReward",
                column: "ZNaturalPersonID",
                principalTable: "ZNaturalPerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZAdministrativeSanction_ZNaturalPerson_ZNaturalPersonID",
                table: "ZAdministrativeSanction",
                column: "ZNaturalPersonID",
                principalTable: "ZNaturalPerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZDishonestExecutor_ZNaturalPerson_ZNaturalPersonID",
                table: "ZDishonestExecutor",
                column: "ZNaturalPersonID",
                principalTable: "ZNaturalPerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZOtherCommendation_ZNaturalPerson_ZNaturalPersonID",
                table: "ZOtherCommendation",
                column: "ZNaturalPersonID",
                principalTable: "ZNaturalPerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZOtherPenalties_ZNaturalPerson_ZNaturalPersonID",
                table: "ZOtherPenalties",
                column: "ZNaturalPersonID",
                principalTable: "ZNaturalPerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FAdministrativeCoercion_FLegalPerson_FLegalPersonID",
                table: "FAdministrativeCoercion");

            migrationBuilder.DropForeignKey(
                name: "FK_FAdministrativeExamination_FLegalPerson_FLegalPersonID",
                table: "FAdministrativeExamination");

            migrationBuilder.DropForeignKey(
                name: "FK_FAdministrativeLicensing_FLegalPerson_FLegalPersonID",
                table: "FAdministrativeLicensing");

            migrationBuilder.DropForeignKey(
                name: "FK_FAdministrativeReward_FLegalPerson_FLegalPersonID",
                table: "FAdministrativeReward");

            migrationBuilder.DropForeignKey(
                name: "FK_FAdministrativeSanction_FLegalPerson_FLegalPersonID",
                table: "FAdministrativeSanction");

            migrationBuilder.DropForeignKey(
                name: "FK_FDishonestExecutor_FLegalPerson_FLegalPersonID",
                table: "FDishonestExecutor");

            migrationBuilder.DropForeignKey(
                name: "FK_FOtherCommendation_FLegalPerson_FLegalPersonID",
                table: "FOtherCommendation");

            migrationBuilder.DropForeignKey(
                name: "FK_FOtherPenalties_FLegalPerson_FLegalPersonID",
                table: "FOtherPenalties");

            migrationBuilder.DropForeignKey(
                name: "FK_ZAdministrativeCoercion_ZNaturalPerson_ZNaturalPersonID",
                table: "ZAdministrativeCoercion");

            migrationBuilder.DropForeignKey(
                name: "FK_ZAdministrativeLicensing_ZNaturalPerson_ZNaturalPersonID",
                table: "ZAdministrativeLicensing");

            migrationBuilder.DropForeignKey(
                name: "FK_ZAdministrativeReward_ZNaturalPerson_ZNaturalPersonID",
                table: "ZAdministrativeReward");

            migrationBuilder.DropForeignKey(
                name: "FK_ZAdministrativeSanction_ZNaturalPerson_ZNaturalPersonID",
                table: "ZAdministrativeSanction");

            migrationBuilder.DropForeignKey(
                name: "FK_ZDishonestExecutor_ZNaturalPerson_ZNaturalPersonID",
                table: "ZDishonestExecutor");

            migrationBuilder.DropForeignKey(
                name: "FK_ZOtherCommendation_ZNaturalPerson_ZNaturalPersonID",
                table: "ZOtherCommendation");

            migrationBuilder.DropForeignKey(
                name: "FK_ZOtherPenalties_ZNaturalPerson_ZNaturalPersonID",
                table: "ZOtherPenalties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZOtherPenalties",
                table: "ZOtherPenalties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZOtherCommendation",
                table: "ZOtherCommendation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZNaturalPerson",
                table: "ZNaturalPerson");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZDishonestExecutor",
                table: "ZDishonestExecutor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZAdministrativeSanction",
                table: "ZAdministrativeSanction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZAdministrativeReward",
                table: "ZAdministrativeReward");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZAdministrativeLicensing",
                table: "ZAdministrativeLicensing");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZAdministrativeCoercion",
                table: "ZAdministrativeCoercion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SysLog",
                table: "SysLog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SysException",
                table: "SysException");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FOtherPenalties",
                table: "FOtherPenalties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FOtherCommendation",
                table: "FOtherCommendation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FLegalPerson",
                table: "FLegalPerson");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FDishonestExecutor",
                table: "FDishonestExecutor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FAdministrativeSanction",
                table: "FAdministrativeSanction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FAdministrativeReward",
                table: "FAdministrativeReward");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FAdministrativeLicensing",
                table: "FAdministrativeLicensing");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FAdministrativeExamination",
                table: "FAdministrativeExamination");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FAdministrativeCoercion",
                table: "FAdministrativeCoercion");

            migrationBuilder.RenameTable(
                name: "ZOtherPenalties",
                newName: "ZOtherPenaltiess");

            migrationBuilder.RenameTable(
                name: "ZOtherCommendation",
                newName: "ZOtherCommendations");

            migrationBuilder.RenameTable(
                name: "ZNaturalPerson",
                newName: "ZNaturalPersons");

            migrationBuilder.RenameTable(
                name: "ZDishonestExecutor",
                newName: "ZDishonestExecutors");

            migrationBuilder.RenameTable(
                name: "ZAdministrativeSanction",
                newName: "ZAdministrativeSanctions");

            migrationBuilder.RenameTable(
                name: "ZAdministrativeReward",
                newName: "ZAdministrativeRewards");

            migrationBuilder.RenameTable(
                name: "ZAdministrativeLicensing",
                newName: "ZAdministrativeLicensings");

            migrationBuilder.RenameTable(
                name: "ZAdministrativeCoercion",
                newName: "ZAdministrativeCoercions");

            migrationBuilder.RenameTable(
                name: "SysLog",
                newName: "SysLogs");

            migrationBuilder.RenameTable(
                name: "SysException",
                newName: "SysExceptions");

            migrationBuilder.RenameTable(
                name: "FOtherPenalties",
                newName: "FOtherPenaltiess");

            migrationBuilder.RenameTable(
                name: "FOtherCommendation",
                newName: "FOtherCommendations");

            migrationBuilder.RenameTable(
                name: "FLegalPerson",
                newName: "FLegalPersons");

            migrationBuilder.RenameTable(
                name: "FDishonestExecutor",
                newName: "FDishonestExecutors");

            migrationBuilder.RenameTable(
                name: "FAdministrativeSanction",
                newName: "FAdministrativeSanctions");

            migrationBuilder.RenameTable(
                name: "FAdministrativeReward",
                newName: "FAdministrativeRewards");

            migrationBuilder.RenameTable(
                name: "FAdministrativeLicensing",
                newName: "FAdministrativeLicensings");

            migrationBuilder.RenameTable(
                name: "FAdministrativeExamination",
                newName: "FAdministrativeExaminations");

            migrationBuilder.RenameTable(
                name: "FAdministrativeCoercion",
                newName: "FAdministrativeCoercions");

            migrationBuilder.RenameIndex(
                name: "IX_ZOtherPenalties_ZNaturalPersonID",
                table: "ZOtherPenaltiess",
                newName: "IX_ZOtherPenaltiess_ZNaturalPersonID");

            migrationBuilder.RenameIndex(
                name: "IX_ZOtherCommendation_ZNaturalPersonID",
                table: "ZOtherCommendations",
                newName: "IX_ZOtherCommendations_ZNaturalPersonID");

            migrationBuilder.RenameIndex(
                name: "IX_ZDishonestExecutor_ZNaturalPersonID",
                table: "ZDishonestExecutors",
                newName: "IX_ZDishonestExecutors_ZNaturalPersonID");

            migrationBuilder.RenameIndex(
                name: "IX_ZAdministrativeSanction_ZNaturalPersonID",
                table: "ZAdministrativeSanctions",
                newName: "IX_ZAdministrativeSanctions_ZNaturalPersonID");

            migrationBuilder.RenameIndex(
                name: "IX_ZAdministrativeReward_ZNaturalPersonID",
                table: "ZAdministrativeRewards",
                newName: "IX_ZAdministrativeRewards_ZNaturalPersonID");

            migrationBuilder.RenameIndex(
                name: "IX_ZAdministrativeLicensing_ZNaturalPersonID",
                table: "ZAdministrativeLicensings",
                newName: "IX_ZAdministrativeLicensings_ZNaturalPersonID");

            migrationBuilder.RenameIndex(
                name: "IX_ZAdministrativeCoercion_ZNaturalPersonID",
                table: "ZAdministrativeCoercions",
                newName: "IX_ZAdministrativeCoercions_ZNaturalPersonID");

            migrationBuilder.RenameIndex(
                name: "IX_FOtherPenalties_FLegalPersonID",
                table: "FOtherPenaltiess",
                newName: "IX_FOtherPenaltiess_FLegalPersonID");

            migrationBuilder.RenameIndex(
                name: "IX_FOtherCommendation_FLegalPersonID",
                table: "FOtherCommendations",
                newName: "IX_FOtherCommendations_FLegalPersonID");

            migrationBuilder.RenameIndex(
                name: "IX_FDishonestExecutor_FLegalPersonID",
                table: "FDishonestExecutors",
                newName: "IX_FDishonestExecutors_FLegalPersonID");

            migrationBuilder.RenameIndex(
                name: "IX_FAdministrativeSanction_FLegalPersonID",
                table: "FAdministrativeSanctions",
                newName: "IX_FAdministrativeSanctions_FLegalPersonID");

            migrationBuilder.RenameIndex(
                name: "IX_FAdministrativeReward_FLegalPersonID",
                table: "FAdministrativeRewards",
                newName: "IX_FAdministrativeRewards_FLegalPersonID");

            migrationBuilder.RenameIndex(
                name: "IX_FAdministrativeLicensing_FLegalPersonID",
                table: "FAdministrativeLicensings",
                newName: "IX_FAdministrativeLicensings_FLegalPersonID");

            migrationBuilder.RenameIndex(
                name: "IX_FAdministrativeExamination_FLegalPersonID",
                table: "FAdministrativeExaminations",
                newName: "IX_FAdministrativeExaminations_FLegalPersonID");

            migrationBuilder.RenameIndex(
                name: "IX_FAdministrativeCoercion_FLegalPersonID",
                table: "FAdministrativeCoercions",
                newName: "IX_FAdministrativeCoercions_FLegalPersonID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZOtherPenaltiess",
                table: "ZOtherPenaltiess",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZOtherCommendations",
                table: "ZOtherCommendations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZNaturalPersons",
                table: "ZNaturalPersons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZDishonestExecutors",
                table: "ZDishonestExecutors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZAdministrativeSanctions",
                table: "ZAdministrativeSanctions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZAdministrativeRewards",
                table: "ZAdministrativeRewards",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZAdministrativeLicensings",
                table: "ZAdministrativeLicensings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZAdministrativeCoercions",
                table: "ZAdministrativeCoercions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SysLogs",
                table: "SysLogs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SysExceptions",
                table: "SysExceptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FOtherPenaltiess",
                table: "FOtherPenaltiess",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FOtherCommendations",
                table: "FOtherCommendations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FLegalPersons",
                table: "FLegalPersons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FDishonestExecutors",
                table: "FDishonestExecutors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FAdministrativeSanctions",
                table: "FAdministrativeSanctions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FAdministrativeRewards",
                table: "FAdministrativeRewards",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FAdministrativeLicensings",
                table: "FAdministrativeLicensings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FAdministrativeExaminations",
                table: "FAdministrativeExaminations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FAdministrativeCoercions",
                table: "FAdministrativeCoercions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FAdministrativeCoercions_FLegalPersons_FLegalPersonID",
                table: "FAdministrativeCoercions",
                column: "FLegalPersonID",
                principalTable: "FLegalPersons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FAdministrativeExaminations_FLegalPersons_FLegalPersonID",
                table: "FAdministrativeExaminations",
                column: "FLegalPersonID",
                principalTable: "FLegalPersons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FAdministrativeLicensings_FLegalPersons_FLegalPersonID",
                table: "FAdministrativeLicensings",
                column: "FLegalPersonID",
                principalTable: "FLegalPersons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FAdministrativeRewards_FLegalPersons_FLegalPersonID",
                table: "FAdministrativeRewards",
                column: "FLegalPersonID",
                principalTable: "FLegalPersons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FAdministrativeSanctions_FLegalPersons_FLegalPersonID",
                table: "FAdministrativeSanctions",
                column: "FLegalPersonID",
                principalTable: "FLegalPersons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FDishonestExecutors_FLegalPersons_FLegalPersonID",
                table: "FDishonestExecutors",
                column: "FLegalPersonID",
                principalTable: "FLegalPersons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FOtherCommendations_FLegalPersons_FLegalPersonID",
                table: "FOtherCommendations",
                column: "FLegalPersonID",
                principalTable: "FLegalPersons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FOtherPenaltiess_FLegalPersons_FLegalPersonID",
                table: "FOtherPenaltiess",
                column: "FLegalPersonID",
                principalTable: "FLegalPersons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZAdministrativeCoercions_ZNaturalPersons_ZNaturalPersonID",
                table: "ZAdministrativeCoercions",
                column: "ZNaturalPersonID",
                principalTable: "ZNaturalPersons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZAdministrativeLicensings_ZNaturalPersons_ZNaturalPersonID",
                table: "ZAdministrativeLicensings",
                column: "ZNaturalPersonID",
                principalTable: "ZNaturalPersons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZAdministrativeRewards_ZNaturalPersons_ZNaturalPersonID",
                table: "ZAdministrativeRewards",
                column: "ZNaturalPersonID",
                principalTable: "ZNaturalPersons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZAdministrativeSanctions_ZNaturalPersons_ZNaturalPersonID",
                table: "ZAdministrativeSanctions",
                column: "ZNaturalPersonID",
                principalTable: "ZNaturalPersons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZDishonestExecutors_ZNaturalPersons_ZNaturalPersonID",
                table: "ZDishonestExecutors",
                column: "ZNaturalPersonID",
                principalTable: "ZNaturalPersons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZOtherCommendations_ZNaturalPersons_ZNaturalPersonID",
                table: "ZOtherCommendations",
                column: "ZNaturalPersonID",
                principalTable: "ZNaturalPersons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZOtherPenaltiess_ZNaturalPersons_ZNaturalPersonID",
                table: "ZOtherPenaltiess",
                column: "ZNaturalPersonID",
                principalTable: "ZNaturalPersons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
