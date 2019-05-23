using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class MasCambios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calificaciones_Ciclos_cicloClave",
                table: "Calificaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Calificaciones_Cursos_cursoClave",
                table: "Calificaciones");

            migrationBuilder.DropIndex(
                name: "IX_Calificaciones_cicloClave",
                table: "Calificaciones");

            migrationBuilder.DropIndex(
                name: "IX_Calificaciones_cursoClave",
                table: "Calificaciones");

            migrationBuilder.DropColumn(
                name: "cicloClave",
                table: "Calificaciones");

            migrationBuilder.AlterColumn<string>(
                name: "cursoClave",
                table: "Calificaciones",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CursoscursoClave",
                table: "Calificaciones",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Persona",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    code = table.Column<string>(nullable: false),
                    numberCode = table.Column<int>(nullable: false),
                    alumnoId = table.Column<int>(nullable: false),
                    profesorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros", x => x.code);
                    table.ForeignKey(
                        name: "FK_Registros_Alumnos_alumnoId",
                        column: x => x.alumnoId,
                        principalTable: "Alumnos",
                        principalColumn: "alumnoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registros_Profesores_profesorId",
                        column: x => x.profesorId,
                        principalTable: "Profesores",
                        principalColumn: "profesorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calificaciones_CursoscursoClave",
                table: "Calificaciones",
                column: "CursoscursoClave");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_alumnoId",
                table: "Registros",
                column: "alumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_profesorId",
                table: "Registros",
                column: "profesorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Calificaciones_Cursos_CursoscursoClave",
                table: "Calificaciones",
                column: "CursoscursoClave",
                principalTable: "Cursos",
                principalColumn: "cursoClave",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calificaciones_Cursos_CursoscursoClave",
                table: "Calificaciones");

            migrationBuilder.DropTable(
                name: "Registros");

            migrationBuilder.DropIndex(
                name: "IX_Calificaciones_CursoscursoClave",
                table: "Calificaciones");

            migrationBuilder.DropColumn(
                name: "CursoscursoClave",
                table: "Calificaciones");

            migrationBuilder.AlterColumn<int>(
                name: "cursoClave",
                table: "Calificaciones",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cicloClave",
                table: "Calificaciones",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Persona",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Calificaciones_cicloClave",
                table: "Calificaciones",
                column: "cicloClave");

            migrationBuilder.CreateIndex(
                name: "IX_Calificaciones_cursoClave",
                table: "Calificaciones",
                column: "cursoClave");

            migrationBuilder.AddForeignKey(
                name: "FK_Calificaciones_Ciclos_cicloClave",
                table: "Calificaciones",
                column: "cicloClave",
                principalTable: "Ciclos",
                principalColumn: "cicloClave",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Calificaciones_Cursos_cursoClave",
                table: "Calificaciones",
                column: "cursoClave",
                principalTable: "Cursos",
                principalColumn: "cursoClave",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
