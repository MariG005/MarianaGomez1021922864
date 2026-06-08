# CalculadoraApp - C#

**Asignatura:** Aplicaciones y Servicios Web  
**Actividad:** Guía de Trabajo No.5 - Taller evaluativo (20%)  
**Institución:** ITM - Institución Universitaria

## Descripción

Aplicación de consola en C# con operaciones matemáticas básicas (suma, resta, multiplicación y división), configurada con un flujo completo de **CI/CD** usando **GitHub Actions**.

## Estructura del Proyecto

```
CalculadoraApp/
├── .github/
│   └── workflows/
│       └── cicd.yml          # Pipeline CI/CD
├── src/
│   ├── Calculator.cs         # Lógica principal
│   └── CalculadoraApp.csproj
├── tests/
│   ├── CalculatorTests.cs    # Pruebas unitarias (xUnit)
│   └── CalculadoraApp.Tests.csproj
├── CalculadoraApp.sln
├── .gitignore
└── README.md
```

## Flujo CI/CD

Cada `push` a la rama `main` activa automáticamente:

1. **Build** — Restaura dependencias y compila en modo Release.
2. **Test** — Ejecuta las pruebas unitarias con xUnit.
3. **Publish** — Genera el artefacto y lo sube a GitHub Actions.

## Tecnologías

- C# / .NET 8
- xUnit (pruebas unitarias)
- GitHub Actions (CI/CD)

## Cómo ejecutar localmente

```bash
# Compilar
dotnet build CalculadoraApp.sln

# Ejecutar
dotnet run --project src/CalculadoraApp.csproj

# Pruebas
dotnet test tests/CalculadoraApp.Tests.csproj
```

Cambios en dos clases y en el README
