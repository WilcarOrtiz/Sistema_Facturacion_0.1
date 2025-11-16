# Sistema de Facturación 0.1

> Sistema de facturación desarrollado en C# con arquitectura en capas, diseñado para gestionar la emisión de facturas y control de datos de clientes y productos.

## 📋 Descripción

**Sistema de Facturación 0.1** es un proyecto universitario (Proyecto P-III) que implementa un sistema completo de facturación con interfaz gráfica. El sistema está diseñado con una arquitectura en capas que separa la presentación, lógica de negocio, acceso a datos y entidades, facilitando el mantenimiento y escalabilidad del código.

### Características principales

- ✅ Gestión de clientes
- ✅ Gestión de productos
- ✅ Generación de facturas
- ✅ Interfaz gráfica amigable
- ✅ Exportación de facturas a PDF
- ✅ Persistencia de datos

---

## 🛠️ Stack Tecnológico

| Tecnología | Descripción |
|-----------|-------------|
| **Lenguaje** | C# (.NET Framework) |
| **IDE** | Visual Studio 2022 |
| **GUI** | Windows Forms |
| **Base de Datos** | SQL Server (configurable) |
| **Generación de PDF** | Librerías PDF integradas |

---

## 📁 Estructura del Proyecto

El proyecto está organizado en 4 capas principales siguiendo el patrón de arquitectura en capas:

\`\`\`
Sistema_Facturacion_0.1/
│
├── 📦 Presentacion_GUI/          # Capa de Presentación
│   └── Interfaz gráfica (Windows Forms)
│
├── 📦 Logica/                    # Capa de Lógica de Negocio
│   └── Reglas de negocio y procesos
│
├── 📦 Datos/                     # Capa de Acceso a Datos
│   └── Conexión y operaciones con BD
│
├── 📦 Entidades/                 # Capa de Entidades
│   └── Modelos de datos (Cliente, Producto, Factura, etc.)
│
├── 📁 Recursos Graficos/         # Imágenes y recursos visuales
├── 📁 RecursosPDF/               # Plantillas y recursos PDF
├── 📁 Datos/                     # Archivos de datos
│
└── 📄 Sistema_Facturacion_0.1.sln # Solución Visual Studio

\`\`\`

### Descripción de las capas:

#### 🎨 **Presentacion_GUI**
Contiene toda la interfaz gráfica desarrollada en Windows Forms. Aquí se encuentran los formularios para:
- Ingreso de clientes
- Ingreso de productos
- Generación de facturas
- Visualización de reportes

#### 💼 **Logica**
Implementa la lógica de negocio del sistema:
- Validaciones
- Cálculos de facturas
- Reglas de generación de facturas
- Funciones auxiliares

#### 💾 **Datos**
Gestiona la conexión y operaciones con la base de datos:
- Conexión a SQL Server
- Operaciones CRUD (Create, Read, Update, Delete)
- Consultas a base de datos

#### 📦 **Entidades**
Define los modelos de datos utilizados en toda la aplicación:
- `Cliente`
- `Producto`
- `Factura`
- `Detalle de Factura`
- Otras entidades del negocio

---

## 🚀 Instalación y Configuración

### Requisitos Previos

- **Visual Studio 2022** (o superior)
- **.NET Framework 4.7.2** (o superior)
- **SQL Server 2019** (o compatible)
- **Windows 10/11**

### Pasos de instalación

1. **Clonar el repositorio**
   \`\`\`bash
   git clone https://github.com/WilcarOrtiz/Sistema_Facturacion_0.1.git
   cd Sistema_Facturacion_0.1
   \`\`\`

2. **Abrir la solución en Visual Studio**
   - Hacer doble clic en `Sistema_Facturacion_0.1.sln`
   - O abrir Visual Studio → File → Open → Project/Solution

3. **Restaurar dependencias**
   - En Visual Studio, ir a: `Build` → `Build Solution` (o presionar Ctrl+Shift+B)
   - Las dependencias NuGet se descargarán automáticamente

4. **Configurar la base de datos**
   - Ubicar el archivo de configuración de conexión (generalmente en la capa Datos)
   - Actualizar la cadena de conexión con los datos de tu servidor SQL Server:
     \`\`\`
     Server=tu_servidor;Database=Facturacion;User Id=sa;Password=tu_password;
     \`\`\`
   - Ejecutar los scripts SQL necesarios para crear las tablas

5. **Compilar el proyecto**
   - Presionar `Ctrl+Shift+B` o ir a `Build` → `Build Solution`

6. **Ejecutar la aplicación**
   - Establecer `Presentacion_GUI` como proyecto de inicio
   - Presionar `F5` o `Ctrl+F5` para ejecutar

---

## 📖 Guía de Uso

### Gestionar Clientes

1. Abrir la aplicación
2. Navegar a la sección "Clientes"
3. Hacer clic en "Nuevo Cliente"
4. Rellenar los datos solicitados (nombre, RUC, dirección, etc.)
5. Guardar

### Gestionar Productos

1. Navegar a la sección "Productos"
2. Hacer clic en "Nuevo Producto"
3. Ingresar detalles (código, descripción, precio, stock)
4. Guardar

### Generar una Factura

1. Navegar a la sección "Facturas"
2. Crear nueva factura
3. Seleccionar el cliente
4. Agregar productos a la factura
5. Revisar el total
6. Guardar y generar PDF

---

## 🔧 Configuración Avanzada

### Cambiar cadena de conexión

En el archivo de configuración de la capa `Datos`, busca la sección de conexión:

```csharp
string connectionString = "Server=tu_servidor;Database=Facturacion;User Id=sa;Password=tu_password;";
