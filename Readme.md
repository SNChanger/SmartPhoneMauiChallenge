#project overview

It's a repository where I tried out a framework while other people were developing it on Spajam.

## Technical configuration

### Development environment

Visual Studio 2022 compatible

### Creating each page

Created using .Net MAUI template file

### Reference materials when creating materials

https://github.blog/2022-02-14-include-diagrams-markdown-files-mermaid/

### ReleasePlan LastFlow
```mermaid
flowchart LR
    subgraph App
        subgraph Menu
           userMemoTab -->userMemoDetail
           itemListTab -->itemList
           facilitySearchTab -->facilitySearchDisplay
           medicinedinputFormTab --> medicinedinputForm
        end
    end
User --> App --> Display
```
#### Planned implementation details for each screen
##### List of past consultations
##### Screen side overview
Display the consultation history list of saved contents on the input screen
Click on the consultation history to go to the details screen

##### data transition
```mermaid
sequenceDiagram
    participant Event source program
    participant Get medicine list
    participant Destination
    Event source program->>Get medicine list: Call to obtain a list of examination results for the specified account
    Get medicine list->>Destination: Execute the command to obtain a list of examination results for the selected account
    Destination->>Get medicine list: Returns the execution results of the command to obtain a list of consultation results for the selected account.
    Get medicine list->>Event source program: Returns the results of the selected account's consultation results list
    loop Display data per page
    Event source program->>Event source program: Regarding the acquisition list, reflected on the XAML side
    end
```
##### Building search screen
##### Screen overview
A screen where you can receive medicine under specified conditions
Click on the displayed building information to move to the details screen
##### data transition
```mermaid
sequenceDiagram
    participant Event source program
    participant Building overview list
    participant Destination
    Event source program->>Event source program: Enter search conditions according to the prescription you want
    Event source program->>Get building overview list: Call to get building overview list
    Get building overview list->>Destination: Execute building outline list acquisition command
    Destination->>Get building overview list: Execute the building summary list acquisition command and return the results
    Get building overview list->>Event source program: Returns screen contents according to search results
    loop Display data per page
    Event source program->>Event source program: Reflect the acquired building information on the XAML side
    end
```


##### Consultation result input screen
###### Screen overview
Enter details at the time of consultation
####### Input items
Click on the displayed building information to move to the detailed screen

   Pharmacy name(Branch name)
   Medical institution name(University Hospital)
   name(Name at the time of purchase, name of agent or principal)
   date of birth(Target person's birthday Will be moved once the account page is created)


##### data transition
```mermaid
sequenceDiagram
    participant Event source program
    participant Save consultation details
    participant Destination(Medical examination results storage DB)
    Event source program->>Event source program: Reflect the information entered when visiting the doctor
    Event source program->>Save consultation details: Call to save the consultation details using the contents of the consultation as an argument.
    Save consultation details->>Destination: Execute the process of reflecting the consultation results in the DB
    Destination->>Save consultation details: Save the consultation details and return the results
    Save consultation details->>Event source program: Save input results and return
    Event source program->>Event source program: Reflect the save execution result in the screen dialog
```









