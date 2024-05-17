# Herramienta de Listado de Archivos 🗂️

Este proyecto es una aplicación de Windows Forms escrita en PowerShell. Permite a los usuarios seleccionar un directorio, aplicar filtros a carpetas y tipos de archivos, buscar archivos específicos y generar un archivo de salida que contiene las rutas y contenidos de los archivos seleccionados. Esta herramienta está diseñada para ayudar a los desarrolladores a optimizar su flujo de trabajo pasando fácilmente archivos de código a ChatGPT para obtener nuevos chats más fluidos y eficientes.

## Características 🌟

- Selección de un directorio para listar archivos.
- Filtrado de carpetas y tipos de archivos.
- Búsqueda de archivos por nombre.
- Selección de la ubicación del archivo de salida.
- Generación de un archivo de salida con las rutas y contenidos de los archivos seleccionados.
- Barra de progreso que muestra el avance de la generación del archivo de salida.

## Componentes de la Interfaz de Usuario 🖥️

- **Ventana Principal**: Una ventana principal que contiene todos los elementos de la interfaz de usuario.
- **Botón Seleccionar Directorio**: Permite al usuario seleccionar un directorio para listar archivos.
- **Etiqueta de Directorio**: Muestra el directorio seleccionado.
- **Lista de Archivos**: Una lista con casillas de verificación que muestra los archivos del directorio seleccionado.
- **Etiqueta y Cuadro de Texto de Filtros de Carpetas**: Permite al usuario ingresar filtros para excluir carpetas específicas.
- **Etiqueta y Cuadro de Texto de Búsqueda de Archivos**: Permite al usuario buscar archivos específicos por nombre.
- **Etiqueta y Cuadro de Texto de Filtros de Tipo de Archivo**: Permite al usuario ingresar filtros para incluir solo ciertos tipos de archivos.
- **Botón Seleccionar Ubicación de Output**: Permite al usuario seleccionar la ubicación del archivo de salida.
- **Etiqueta de Ubicación de Output**: Muestra la ubicación seleccionada del archivo de salida.
- **Barra de Progreso**: Muestra el progreso de la generación del archivo de salida.
- **Botón Generar Output**: Genera el archivo de salida con las rutas y contenidos de los archivos seleccionados.

## Funcionalidad 🚀

### Selección de Directorio

Cuando el usuario hace clic en el botón **Seleccionar Directorio**, se abre un cuadro de diálogo de selección de carpetas. Si el usuario selecciona un directorio, la etiqueta de directorio muestra la ruta seleccionada y la lista de archivos se actualiza con los archivos del directorio, excluyendo las carpetas y tipos de archivos especificados en los filtros.

### Búsqueda de Archivos

El cuadro de texto de búsqueda permite al usuario buscar archivos por nombre. A medida que el usuario escribe en el cuadro de texto, la lista de archivos se actualiza para mostrar solo los archivos que coinciden con el texto de búsqueda.

### Filtros de Carpetas y Tipos de Archivo

El cuadro de texto de filtros de carpetas permite al usuario ingresar nombres de carpetas que se deben excluir de la lista de archivos. El cuadro de texto de filtros de tipo de archivo permite al usuario ingresar extensiones de archivo (por ejemplo, `.txt`, `.jpg`) que se deben incluir en la lista de archivos.

### Selección de Ubicación de Output

El botón **Seleccionar Ubicación de Output** abre un cuadro de diálogo de guardado de archivos que permite al usuario seleccionar la ubicación y el nombre del archivo de salida. La etiqueta de ubicación de output muestra la ruta seleccionada.

### Generación del Archivo de Salida

El botón **Generar Output** genera un archivo de salida en la ubicación seleccionada. El archivo de salida contiene la ruta y el contenido de cada archivo seleccionado en la lista. La barra de progreso muestra el avance de la generación del archivo de salida.

## Uso 📋

1. Ejecuta el script en PowerShell.
2. Selecciona un directorio haciendo clic en el botón **Seleccionar Directorio**.
3. Opcionalmente, ingresa filtros de carpetas y tipos de archivo en los cuadros de texto correspondientes.
4. Busca archivos específicos utilizando el cuadro de texto de búsqueda.
5. Selecciona la ubicación del archivo de salida haciendo clic en el botón **Seleccionar Ubicación de Output**.
6. Genera el archivo de salida haciendo clic en el botón **Generar Output**.

## Requisitos ⚙️

- PowerShell
- .NET Framework (para utilizar las clases de Windows Forms)

## Notas 📝

- El script utiliza la clase `System.Windows.Forms` para crear la interfaz de usuario.
- El archivo de salida generado incluye tanto la ruta como el contenido de cada archivo seleccionado, separados por doble línea nueva.
- Esta herramienta es especialmente útil para los desarrolladores que quieren pasar sus archivos de código a ChatGPT de manera fluida, mejorando su flujo de trabajo y permitiendo nuevas sesiones de chat más eficientes.

¡Disfruta de un flujo de trabajo optimizado con tus archivos de código y ChatGPT! 💻🤖
