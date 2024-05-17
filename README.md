# File Listing Tool 🗂️

This project is a Windows Forms application written in PowerShell. It allows users to select a directory, apply filters to folders and file types, search for specific files, and generate an output file containing the paths and contents of the selected files. This tool is designed to help developers streamline their workflow by easily passing code files to ChatGPT for smoother and more efficient new chats.

## Features 🌟

- Select a directory to list files.
- Filter folders and file types.
- Search for specific files by name.
- Select the output file location.
- Generate an output file with the paths and contents of selected files.
- Progress bar showing the generation progress of the output file.

## User Interface Components 🖥️

- **Main Window**: A main window containing all UI elements.
- **Select Directory Button**: Allows the user to select a directory to list files.
- **Directory Label**: Displays the selected directory.
- **File List**: A checklist displaying the files in the selected directory.
- **Folder Filters Label and TextBox**: Allows the user to enter filters to exclude specific folders.
- **File Search Label and TextBox**: Allows the user to search for specific files by name.
- **File Type Filters Label and TextBox**: Allows the user to enter filters to include only certain file types.
- **Select Output Location Button**: Allows the user to select the output file location.
- **Output Location Label**: Displays the selected output file location.
- **Progress Bar**: Shows the progress of the output file generation.
- **Generate Output Button**: Generates the output file with the paths and contents of the selected files.

## Functionality 🚀

### Directory Selection

When the user clicks the **Select Directory** button, a folder selection dialog opens. If the user selects a directory, the directory label displays the selected path, and the file list updates with the files from the directory, excluding folders and file types specified in the filters.

### File Search

The search textbox allows the user to search for files by name. As the user types in the search textbox, the file list updates to show only the files that match the search text.

### Folder and File Type Filters

The folder filters textbox allows the user to enter folder names to exclude from the file list. The file type filters textbox allows the user to enter file extensions (e.g., `.txt`, `.jpg`) to include in the file list.

### Output Location Selection

The **Select Output Location** button opens a save file dialog allowing the user to select the location and name of the output file. The output location label displays the selected path.

### Output File Generation

The **Generate Output** button generates an output file at the selected location. The output file contains the path and content of each selected file in the list. The progress bar shows the progress of the output file generation.

## Usage 📋

1. Run the script in PowerShell.
2. Select a directory by clicking the **Select Directory** button.
3. Optionally, enter folder and file type filters in the respective textboxes.
4. Search for specific files using the search textbox.
5. Select the output file location by clicking the **Select Output Location** button.
6. Generate the output file by clicking the **Generate Output** button.

## Requirements ⚙️

- PowerShell
- .NET Framework (to use Windows Forms classes)

## Notes 📝

- The script uses the `System.Windows.Forms` class to create the user interface.
- The generated output file includes both the path and the content of each selected file, separated by double newlines.
- This tool is especially useful for developers who want to seamlessly pass their code files to ChatGPT, enhancing their workflow and enabling smoother new chat sessions.

Enjoy a streamlined workflow with your code files and ChatGPT! 💻🤖
