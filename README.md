# KanbanflowDatagrabber

KanbanflowDatagrabber is a powerful utility written in C# designed to connect to your Kanbanflow account and download all available data from a specified Kanban board. This tool simplifies the process of exporting your board data for further local analysis, empowering you to identify trends, track progress, and optimize your team's performance.

## Features

- Connect to your Kanbanflow account securely with API authentication
- Download all available data from a specified Kanban board
- Export data in a structured format (e.g., JSON, CSV) for further local analysis
- Easily filter and customize the data you want to export
- Cross-platform support for Windows, macOS, and Linux (using .NET Core)

## Prerequisites

- .NET Core 3.1 SDK or later

## Installation

1. Clone the KanbanflowDatagrabber repository:

```bash
git clone https://github.com/yourusername/KanbanflowDatagrabber.git
```

2. Navigate to the project directory:

```bash
cd KanbanflowDatagrabber
```

3. Build the project:

```bash
dotnet build
```

## Usage

1. Obtain your Kanbanflow API key:

   - Log in to your Kanbanflow account
   - Navigate to the "Account" settings
   - Click "API key," and copy the provided key

2. Run the KanbanflowDatagrabber script:

```bash
dotnet run --api-key YOUR_API_KEY --board-id BOARD_ID
```

3. The script will download all available data from the specified board and save it in a structured format (e.g., JSON, CSV) for further local analysis.

## Customization

You can customize the data you want to export by modifying the C# code or using additional command-line options. For example, you can choose to include or exclude specific columns, filter tasks based on labels, or only download tasks that were updated within a certain time range.

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change. Please make sure to update tests as appropriate.

## License

[MIT](https://choosealicense.com/licenses/mit/)
