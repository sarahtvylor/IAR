Information Asset Registry (IAR) Program
Author: Sarah Taylor

Default JSON Schema located at relative path "JSON\Schemas\DepartmentSchema.json"

USAGE: dotnet run [command] [options]

commands:

    validate-json <path>     Path to file that should be checked against the JSON Schema.
        options:
            --input-schema <path>   Path to JSON Schema file that should overwite the default JSON Schema.

    input-json

    output-registry

    output-stats

Examples:
    > dotnet run validate-json JSON\Test-Files\Admin_sample.json
    > dotnet run validate-json JSON\Test-Files\IT_sample.json --input-schema C:\ExampleSchema
    
