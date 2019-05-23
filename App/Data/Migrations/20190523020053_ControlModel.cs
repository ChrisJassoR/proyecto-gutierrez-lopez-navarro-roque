using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class ControlModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "fecha_entrega",
                table: "CursoActividades",
                newName: "fechaEntrega");

            migrationBuilder.RenameColumn(
                name: "competencia",
                table: "Competencias",
                newName: "descripcion");

            migrationBuilder.AddColumn<string>(
                name: "apellidomaterno",
                table: "Profesores",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "apellidopaterno",
                table: "Profesores",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "apellidoMaterno",
                table: "Alumnos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "apellidoPaterno",
                table: "Alumnos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "materiaClave",
                table: "Actividades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Actividades_materiaClave",
                table: "Actividades",
                column: "materiaClave");

            migrationBuilder.AddForeignKey(
                name: "FK_Actividades_Materias_materiaClave",
                table: "Actividades",
                column: "materiaClave",
                principalTable: "Materias",
                principalColumn: "materiaClave",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actividades_Materias_materiaClave",
                table: "Actividades");

            migrationBuilder.DropIndex(
                name: "IX_Actividades_materiaClave",
                table: "Actividades");

            migrationBuilder.DropColumn(
                name: "apellidomaterno",
                table: "Profesores");

            migrationBuilder.DropColumn(
                name: "apellidopaterno",
                table: "Profesores");

            migrationBuilder.DropColumn(
                name: "apellidoMaterno",
                table: "Alumnos");

            migrationBuilder.DropColumn(
                name: "apellidoPaterno",
                table: "Alumnos");

            migrationBuilder.DropColumn(
                name: "materiaClave",
                table: "Actividades");

            migrationBuilder.RenameColumn(
                name: "fechaEntrega",
                table: "CursoActividades",
                newName: "fecha_entrega");

            migrationBuilder.RenameColumn(
                name: "descripcion",
                table: "Competencias",
                newName: "competencia");
        }
    }
}
