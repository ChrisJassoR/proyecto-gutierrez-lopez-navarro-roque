using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class Cambio_de_relaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actividades_CursoActividades_cursoactividadClave",
                table: "Actividades");

            migrationBuilder.DropForeignKey(
                name: "FK_Actividades_Trabajos_trabajoClave",
                table: "Actividades");

            migrationBuilder.DropForeignKey(
                name: "FK_Alumnos_ActividadAlumnos_actividadalumnoClave",
                table: "Alumnos");

            migrationBuilder.DropForeignKey(
                name: "FK_Alumnos_Calificaciones_calificacionClave",
                table: "Alumnos");

            migrationBuilder.DropForeignKey(
                name: "FK_Carreras_Materias_materiaClave1",
                table: "Carreras");

            migrationBuilder.DropForeignKey(
                name: "FK_Ciclos_Cursos_cursoClave",
                table: "Ciclos");

            migrationBuilder.DropForeignKey(
                name: "FK_Competencias_Trabajos_trabajoClave",
                table: "Competencias");

            migrationBuilder.DropForeignKey(
                name: "FK_CursoActividades_ActividadAlumnos_actividadalumnoClave",
                table: "CursoActividades");

            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Calificaciones_calificacionClave",
                table: "Cursos");

            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_CursoActividades_cursoactividadClave",
                table: "Cursos");

            migrationBuilder.DropForeignKey(
                name: "FK_Materias_Cursos_Cursoclave",
                table: "Materias");

            migrationBuilder.DropForeignKey(
                name: "FK_Profesores_Cursos_CursoClave",
                table: "Profesores");

            migrationBuilder.DropForeignKey(
                name: "FK_Tipos_Competencias_competenciaClave",
                table: "Tipos");

            migrationBuilder.DropIndex(
                name: "IX_Tipos_competenciaClave",
                table: "Tipos");

            migrationBuilder.DropIndex(
                name: "IX_Profesores_CursoClave",
                table: "Profesores");

            migrationBuilder.DropIndex(
                name: "IX_Materias_Cursoclave",
                table: "Materias");

            migrationBuilder.DropIndex(
                name: "IX_Cursos_calificacionClave",
                table: "Cursos");

            migrationBuilder.DropIndex(
                name: "IX_Ciclos_cursoClave",
                table: "Ciclos");

            migrationBuilder.DropIndex(
                name: "IX_Carreras_materiaClave1",
                table: "Carreras");

            migrationBuilder.DropIndex(
                name: "IX_Alumnos_actividadalumnoClave",
                table: "Alumnos");

            migrationBuilder.DropIndex(
                name: "IX_Alumnos_calificacionClave",
                table: "Alumnos");

            migrationBuilder.DropIndex(
                name: "IX_Actividades_cursoactividadClave",
                table: "Actividades");

            migrationBuilder.DropIndex(
                name: "IX_Actividades_trabajoClave",
                table: "Actividades");

            migrationBuilder.DropColumn(
                name: "competenciaClave",
                table: "Tipos");

            migrationBuilder.DropColumn(
                name: "CursoClave",
                table: "Profesores");

            migrationBuilder.DropColumn(
                name: "cursoClave",
                table: "Ciclos");

            migrationBuilder.DropColumn(
                name: "materiaClave",
                table: "Carreras");

            migrationBuilder.DropColumn(
                name: "materiaClave1",
                table: "Carreras");

            migrationBuilder.DropColumn(
                name: "actividadalumnoClave",
                table: "Alumnos");

            migrationBuilder.DropColumn(
                name: "calificacionClave",
                table: "Alumnos");

            migrationBuilder.DropColumn(
                name: "cursoactividadClave",
                table: "Actividades");

            migrationBuilder.DropColumn(
                name: "trabajoClave",
                table: "Actividades");

            migrationBuilder.RenameColumn(
                name: "Cursoclave",
                table: "Materias",
                newName: "carreraClave");

            migrationBuilder.RenameColumn(
                name: "cursoactividadClave",
                table: "Cursos",
                newName: "profesorId");

            migrationBuilder.RenameColumn(
                name: "calificacionClave",
                table: "Cursos",
                newName: "materiaClave");

            migrationBuilder.RenameIndex(
                name: "IX_Cursos_cursoactividadClave",
                table: "Cursos",
                newName: "IX_Cursos_profesorId");

            migrationBuilder.RenameColumn(
                name: "actividadalumnoClave",
                table: "CursoActividades",
                newName: "cursoClave");

            migrationBuilder.RenameIndex(
                name: "IX_CursoActividades_actividadalumnoClave",
                table: "CursoActividades",
                newName: "IX_CursoActividades_cursoClave");

            migrationBuilder.RenameColumn(
                name: "trabajoClave",
                table: "Competencias",
                newName: "tipoClave");

            migrationBuilder.RenameIndex(
                name: "IX_Competencias_trabajoClave",
                table: "Competencias",
                newName: "IX_Competencias_tipoClave");

            migrationBuilder.AddColumn<int>(
                name: "actividadClave",
                table: "Trabajos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "competenciaClave",
                table: "Trabajos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "carreraClave1",
                table: "Materias",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cicloClave",
                table: "Cursos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "cicloClave1",
                table: "Cursos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "materiaClave1",
                table: "Cursos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "actividadClave",
                table: "CursoActividades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "alumnoId",
                table: "Calificaciones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "cicloClave",
                table: "Calificaciones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "cicloClave1",
                table: "Calificaciones",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cursoClave",
                table: "Calificaciones",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "alumnoId",
                table: "ActividadAlumnos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "cursoactividadClave",
                table: "ActividadAlumnos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Trabajos_actividadClave",
                table: "Trabajos",
                column: "actividadClave");

            migrationBuilder.CreateIndex(
                name: "IX_Trabajos_competenciaClave",
                table: "Trabajos",
                column: "competenciaClave");

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
                name: "IX_CursoActividades_actividadClave",
                table: "CursoActividades",
                column: "actividadClave");

            migrationBuilder.CreateIndex(
                name: "IX_Calificaciones_alumnoId",
                table: "Calificaciones",
                column: "alumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Calificaciones_cicloClave1",
                table: "Calificaciones",
                column: "cicloClave1");

            migrationBuilder.CreateIndex(
                name: "IX_Calificaciones_cursoClave",
                table: "Calificaciones",
                column: "cursoClave");

            migrationBuilder.CreateIndex(
                name: "IX_ActividadAlumnos_alumnoId",
                table: "ActividadAlumnos",
                column: "alumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_ActividadAlumnos_cursoactividadClave",
                table: "ActividadAlumnos",
                column: "cursoactividadClave");

            migrationBuilder.AddForeignKey(
                name: "FK_ActividadAlumnos_Alumnos_alumnoId",
                table: "ActividadAlumnos",
                column: "alumnoId",
                principalTable: "Alumnos",
                principalColumn: "alumnoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ActividadAlumnos_CursoActividades_cursoactividadClave",
                table: "ActividadAlumnos",
                column: "cursoactividadClave",
                principalTable: "CursoActividades",
                principalColumn: "cursoactividadClave",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Calificaciones_Alumnos_alumnoId",
                table: "Calificaciones",
                column: "alumnoId",
                principalTable: "Alumnos",
                principalColumn: "alumnoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Calificaciones_Ciclos_cicloClave1",
                table: "Calificaciones",
                column: "cicloClave1",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Competencias_Tipos_tipoClave",
                table: "Competencias",
                column: "tipoClave",
                principalTable: "Tipos",
                principalColumn: "tipoClave",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CursoActividades_Actividades_actividadClave",
                table: "CursoActividades",
                column: "actividadClave",
                principalTable: "Actividades",
                principalColumn: "actividadClave",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CursoActividades_Cursos_cursoClave",
                table: "CursoActividades",
                column: "cursoClave",
                principalTable: "Cursos",
                principalColumn: "cursoClave",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_Cursos_Profesores_profesorId",
                table: "Cursos",
                column: "profesorId",
                principalTable: "Profesores",
                principalColumn: "profesorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Materias_Carreras_carreraClave1",
                table: "Materias",
                column: "carreraClave1",
                principalTable: "Carreras",
                principalColumn: "carreraClave",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trabajos_Actividades_actividadClave",
                table: "Trabajos",
                column: "actividadClave",
                principalTable: "Actividades",
                principalColumn: "actividadClave",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trabajos_Competencias_competenciaClave",
                table: "Trabajos",
                column: "competenciaClave",
                principalTable: "Competencias",
                principalColumn: "competenciaClave",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActividadAlumnos_Alumnos_alumnoId",
                table: "ActividadAlumnos");

            migrationBuilder.DropForeignKey(
                name: "FK_ActividadAlumnos_CursoActividades_cursoactividadClave",
                table: "ActividadAlumnos");

            migrationBuilder.DropForeignKey(
                name: "FK_Calificaciones_Alumnos_alumnoId",
                table: "Calificaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Calificaciones_Ciclos_cicloClave1",
                table: "Calificaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Calificaciones_Cursos_cursoClave",
                table: "Calificaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Competencias_Tipos_tipoClave",
                table: "Competencias");

            migrationBuilder.DropForeignKey(
                name: "FK_CursoActividades_Actividades_actividadClave",
                table: "CursoActividades");

            migrationBuilder.DropForeignKey(
                name: "FK_CursoActividades_Cursos_cursoClave",
                table: "CursoActividades");

            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Ciclos_cicloClave1",
                table: "Cursos");

            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Materias_materiaClave1",
                table: "Cursos");

            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Profesores_profesorId",
                table: "Cursos");

            migrationBuilder.DropForeignKey(
                name: "FK_Materias_Carreras_carreraClave1",
                table: "Materias");

            migrationBuilder.DropForeignKey(
                name: "FK_Trabajos_Actividades_actividadClave",
                table: "Trabajos");

            migrationBuilder.DropForeignKey(
                name: "FK_Trabajos_Competencias_competenciaClave",
                table: "Trabajos");

            migrationBuilder.DropIndex(
                name: "IX_Trabajos_actividadClave",
                table: "Trabajos");

            migrationBuilder.DropIndex(
                name: "IX_Trabajos_competenciaClave",
                table: "Trabajos");

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
                name: "IX_CursoActividades_actividadClave",
                table: "CursoActividades");

            migrationBuilder.DropIndex(
                name: "IX_Calificaciones_alumnoId",
                table: "Calificaciones");

            migrationBuilder.DropIndex(
                name: "IX_Calificaciones_cicloClave1",
                table: "Calificaciones");

            migrationBuilder.DropIndex(
                name: "IX_Calificaciones_cursoClave",
                table: "Calificaciones");

            migrationBuilder.DropIndex(
                name: "IX_ActividadAlumnos_alumnoId",
                table: "ActividadAlumnos");

            migrationBuilder.DropIndex(
                name: "IX_ActividadAlumnos_cursoactividadClave",
                table: "ActividadAlumnos");

            migrationBuilder.DropColumn(
                name: "actividadClave",
                table: "Trabajos");

            migrationBuilder.DropColumn(
                name: "competenciaClave",
                table: "Trabajos");

            migrationBuilder.DropColumn(
                name: "carreraClave1",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "cicloClave",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "cicloClave1",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "materiaClave1",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "actividadClave",
                table: "CursoActividades");

            migrationBuilder.DropColumn(
                name: "alumnoId",
                table: "Calificaciones");

            migrationBuilder.DropColumn(
                name: "cicloClave",
                table: "Calificaciones");

            migrationBuilder.DropColumn(
                name: "cicloClave1",
                table: "Calificaciones");

            migrationBuilder.DropColumn(
                name: "cursoClave",
                table: "Calificaciones");

            migrationBuilder.DropColumn(
                name: "alumnoId",
                table: "ActividadAlumnos");

            migrationBuilder.DropColumn(
                name: "cursoactividadClave",
                table: "ActividadAlumnos");

            migrationBuilder.RenameColumn(
                name: "carreraClave",
                table: "Materias",
                newName: "Cursoclave");

            migrationBuilder.RenameColumn(
                name: "profesorId",
                table: "Cursos",
                newName: "cursoactividadClave");

            migrationBuilder.RenameColumn(
                name: "materiaClave",
                table: "Cursos",
                newName: "calificacionClave");

            migrationBuilder.RenameIndex(
                name: "IX_Cursos_profesorId",
                table: "Cursos",
                newName: "IX_Cursos_cursoactividadClave");

            migrationBuilder.RenameColumn(
                name: "cursoClave",
                table: "CursoActividades",
                newName: "actividadalumnoClave");

            migrationBuilder.RenameIndex(
                name: "IX_CursoActividades_cursoClave",
                table: "CursoActividades",
                newName: "IX_CursoActividades_actividadalumnoClave");

            migrationBuilder.RenameColumn(
                name: "tipoClave",
                table: "Competencias",
                newName: "trabajoClave");

            migrationBuilder.RenameIndex(
                name: "IX_Competencias_tipoClave",
                table: "Competencias",
                newName: "IX_Competencias_trabajoClave");

            migrationBuilder.AddColumn<int>(
                name: "competenciaClave",
                table: "Tipos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CursoClave",
                table: "Profesores",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "cursoClave",
                table: "Ciclos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "materiaClave",
                table: "Carreras",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "materiaClave1",
                table: "Carreras",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "actividadalumnoClave",
                table: "Alumnos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "calificacionClave",
                table: "Alumnos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "cursoactividadClave",
                table: "Actividades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "trabajoClave",
                table: "Actividades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tipos_competenciaClave",
                table: "Tipos",
                column: "competenciaClave");

            migrationBuilder.CreateIndex(
                name: "IX_Profesores_CursoClave",
                table: "Profesores",
                column: "CursoClave");

            migrationBuilder.CreateIndex(
                name: "IX_Materias_Cursoclave",
                table: "Materias",
                column: "Cursoclave");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_calificacionClave",
                table: "Cursos",
                column: "calificacionClave");

            migrationBuilder.CreateIndex(
                name: "IX_Ciclos_cursoClave",
                table: "Ciclos",
                column: "cursoClave");

            migrationBuilder.CreateIndex(
                name: "IX_Carreras_materiaClave1",
                table: "Carreras",
                column: "materiaClave1");

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_actividadalumnoClave",
                table: "Alumnos",
                column: "actividadalumnoClave");

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_calificacionClave",
                table: "Alumnos",
                column: "calificacionClave");

            migrationBuilder.CreateIndex(
                name: "IX_Actividades_cursoactividadClave",
                table: "Actividades",
                column: "cursoactividadClave");

            migrationBuilder.CreateIndex(
                name: "IX_Actividades_trabajoClave",
                table: "Actividades",
                column: "trabajoClave");

            migrationBuilder.AddForeignKey(
                name: "FK_Actividades_CursoActividades_cursoactividadClave",
                table: "Actividades",
                column: "cursoactividadClave",
                principalTable: "CursoActividades",
                principalColumn: "cursoactividadClave",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actividades_Trabajos_trabajoClave",
                table: "Actividades",
                column: "trabajoClave",
                principalTable: "Trabajos",
                principalColumn: "trabajoClave",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Alumnos_ActividadAlumnos_actividadalumnoClave",
                table: "Alumnos",
                column: "actividadalumnoClave",
                principalTable: "ActividadAlumnos",
                principalColumn: "actividadalumnoClave",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Alumnos_Calificaciones_calificacionClave",
                table: "Alumnos",
                column: "calificacionClave",
                principalTable: "Calificaciones",
                principalColumn: "calificacionClave",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carreras_Materias_materiaClave1",
                table: "Carreras",
                column: "materiaClave1",
                principalTable: "Materias",
                principalColumn: "materiaClave",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ciclos_Cursos_cursoClave",
                table: "Ciclos",
                column: "cursoClave",
                principalTable: "Cursos",
                principalColumn: "cursoClave",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Competencias_Trabajos_trabajoClave",
                table: "Competencias",
                column: "trabajoClave",
                principalTable: "Trabajos",
                principalColumn: "trabajoClave",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CursoActividades_ActividadAlumnos_actividadalumnoClave",
                table: "CursoActividades",
                column: "actividadalumnoClave",
                principalTable: "ActividadAlumnos",
                principalColumn: "actividadalumnoClave",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Calificaciones_calificacionClave",
                table: "Cursos",
                column: "calificacionClave",
                principalTable: "Calificaciones",
                principalColumn: "calificacionClave",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_CursoActividades_cursoactividadClave",
                table: "Cursos",
                column: "cursoactividadClave",
                principalTable: "CursoActividades",
                principalColumn: "cursoactividadClave",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Materias_Cursos_Cursoclave",
                table: "Materias",
                column: "Cursoclave",
                principalTable: "Cursos",
                principalColumn: "cursoClave",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Profesores_Cursos_CursoClave",
                table: "Profesores",
                column: "CursoClave",
                principalTable: "Cursos",
                principalColumn: "cursoClave",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tipos_Competencias_competenciaClave",
                table: "Tipos",
                column: "competenciaClave",
                principalTable: "Competencias",
                principalColumn: "competenciaClave",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
