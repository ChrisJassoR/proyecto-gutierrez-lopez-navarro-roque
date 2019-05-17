using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class Correcciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calificaciones_Ciclos_cicloClave1",
                table: "Calificaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Ciclos_cicloClave1",
                table: "Cursos");

            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Materias_materiaClave1",
                table: "Cursos");

            migrationBuilder.DropForeignKey(
                name: "FK_Materias_Carreras_carreraClave1",
                table: "Materias");

            migrationBuilder.DropIndex(
                name: "IX_Materias_carreraClave1",
                table: "Materias");

            migrationBuilder.DropIndex(
                name: "IX_Cursos_cicloClave1",
                table: "Cursos");

            migrationBuilder.DropIndex(
                name: "IX_Cursos_materiaClave1",
                table: "Cursos");

            migrationBuilder.DropIndex(
                name: "IX_Calificaciones_cicloClave1",
                table: "Calificaciones");

            migrationBuilder.DropColumn(
                name: "carreraClave1",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "cicloClave1",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "materiaClave1",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "cicloClave1",
                table: "Calificaciones");

            migrationBuilder.AlterColumn<string>(
                name: "carreraClave",
                table: "Materias",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "materiaClave",
                table: "Materias",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "cicloClave",
                table: "Cursos",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "cicloClave",
                table: "Calificaciones",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Materias_carreraClave",
                table: "Materias",
                column: "carreraClave");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_cicloClave",
                table: "Cursos",
                column: "cicloClave");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_materiaClave",
                table: "Cursos",
                column: "materiaClave");

            migrationBuilder.CreateIndex(
                name: "IX_Calificaciones_cicloClave",
                table: "Calificaciones",
                column: "cicloClave");

            migrationBuilder.AddForeignKey(
                name: "FK_Calificaciones_Ciclos_cicloClave",
                table: "Calificaciones",
                column: "cicloClave",
                principalTable: "Ciclos",
                principalColumn: "cicloClave",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Ciclos_cicloClave",
                table: "Cursos",
                column: "cicloClave",
                principalTable: "Ciclos",
                principalColumn: "cicloClave",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Materias_materiaClave",
                table: "Cursos",
                column: "materiaClave",
                principalTable: "Materias",
                principalColumn: "materiaClave",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Materias_Carreras_carreraClave",
                table: "Materias",
                column: "carreraClave",
                principalTable: "Carreras",
                principalColumn: "carreraClave",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calificaciones_Ciclos_cicloClave",
                table: "Calificaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Ciclos_cicloClave",
                table: "Cursos");

            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Materias_materiaClave",
                table: "Cursos");

            migrationBuilder.DropForeignKey(
                name: "FK_Materias_Carreras_carreraClave",
                table: "Materias");

            migrationBuilder.DropIndex(
                name: "IX_Materias_carreraClave",
                table: "Materias");

            migrationBuilder.DropIndex(
                name: "IX_Cursos_cicloClave",
                table: "Cursos");

            migrationBuilder.DropIndex(
                name: "IX_Cursos_materiaClave",
                table: "Cursos");

            migrationBuilder.DropIndex(
                name: "IX_Calificaciones_cicloClave",
                table: "Calificaciones");

            migrationBuilder.AlterColumn<int>(
                name: "carreraClave",
                table: "Materias",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "materiaClave",
                table: "Materias",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "carreraClave1",
                table: "Materias",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "cicloClave",
                table: "Cursos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cicloClave1",
                table: "Cursos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "materiaClave1",
                table: "Cursos",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "cicloClave",
                table: "Calificaciones",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cicloClave1",
                table: "Calificaciones",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Materias_carreraClave1",
                table: "Materias",
                column: "carreraClave1");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_cicloClave1",
                table: "Cursos",
                column: "cicloClave1");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_materiaClave1",
                table: "Cursos",
                column: "materiaClave1");

            migrationBuilder.CreateIndex(
                name: "IX_Calificaciones_cicloClave1",
                table: "Calificaciones",
                column: "cicloClave1");

            migrationBuilder.AddForeignKey(
                name: "FK_Calificaciones_Ciclos_cicloClave1",
                table: "Calificaciones",
                column: "cicloClave1",
                principalTable: "Ciclos",
                principalColumn: "cicloClave",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Ciclos_cicloClave1",
                table: "Cursos",
                column: "cicloClave1",
                principalTable: "Ciclos",
                principalColumn: "cicloClave",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Materias_materiaClave1",
                table: "Cursos",
                column: "materiaClave1",
                principalTable: "Materias",
                principalColumn: "materiaClave",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Materias_Carreras_carreraClave1",
                table: "Materias",
                column: "carreraClave1",
                principalTable: "Carreras",
                principalColumn: "carreraClave",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
