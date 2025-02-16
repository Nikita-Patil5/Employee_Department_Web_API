# Employee_Department_Web_API

# WebAppWithMVC API Documentation

## Endpoints

### EmployeesController

#### GET: /EmployeeController
- **Description**: Retrieves a list of all employees.
- **Status Codes**: 200 OK
- **Data Requirements**: None

#### GET: /EmployeeController/Details/{id}
- **Description**: Retrieves details of a specific employee by ID.
- **Status Codes**: 200 OK, 404 Not Found
- **Data Requirements**: 
  - `id` (int): The ID of the employee.

#### GET: /EmployeeController/Create
- **Description**: Displays the form to create a new employee.
- **Status Codes**: 200 OK
- **Data Requirements**: None

#### POST: /EmployeeController/Create
- **Description**: Creates a new employee.
- **Status Codes**: 200 OK, 400 Bad Request
- **Data Requirements**: 
  - `Employee` object in the request body.
  - `IFormCollection` collection.

#### GET: /EmployeeController/Edit/{id}
- **Description**: Displays the form to edit an existing employee.
- **Status Codes**: 200 OK, 404 Not Found
- **Data Requirements**: 
  - `id` (int): The ID of the employee.

#### POST: /EmployeeController/Edit/{id}
- **Description**: Updates an existing employee.
- **Status Codes**: 200 OK, 400 Bad Request
- **Data Requirements**: 
  - `id` (int): The ID of the employee.
  - `Employee` object in the request body.

#### GET: /EmployeeController/Delete/{id}
- **Description**: Displays the form to delete an existing employee.
- **Status Codes**: 200 OK, 404 Not Found
- **Data Requirements**: 
  - `id` (int): The ID of the employee.

#### POST: /EmployeeController/Delete/{id}
- **Description**: Deletes an existing employee.
- **Status Codes**: 200 OK, 400 Bad Request
- **Data Requirements**: 
  - `id` (int): The ID of the employee.
  - `IFormCollection` collection.

### DepartmentController

#### GET: /DepartmentController
- **Description**: Retrieves a list of all departments.
- **Status Codes**: 200 OK
- **Data Requirements**: None

#### GET: /DepartmentController/Details/{id}
- **Description**: Retrieves details of a specific department by ID.
- **Status Codes**: 200 OK, 404 Not Found
- **Data Requirements**: 
  - `id` (int): The ID of the department.

#### GET: /DepartmentController/Create
- **Description**: Displays the form to create a new department.
- **Status Codes**: 200 OK
- **Data Requirements**: None

#### POST: /DepartmentController/Create
- **Description**: Creates a new department.
- **Status Codes**: 200 OK, 400 Bad Request
- **Data Requirements**: 
  - `IFormCollection` collection.

#### GET: /DepartmentController/Edit/{id}
- **Description**: Displays the form to edit an existing department.
- **Status Codes**: 200 OK, 404 Not Found
- **Data Requirements**: 
  - `id` (int): The ID of the department.

#### POST: /DepartmentController/Edit/{id}
- **Description**: Updates an existing department.
- **Status Codes**: 200 OK, 400 Bad Request
- **Data Requirements**: 
  - `id` (int): The ID of the department.
  - `IFormCollection` collection.

#### GET: /DepartmentController/Delete/{id}
- **Description**: Displays the form to delete an existing department.
- **Status Codes**: 200 OK, 404 Not Found
- **Data Requirements**: 
  - `id` (int): The ID of the department.

#### POST: /DepartmentController/Delete/{id}
- **Description**: Deletes an existing department.
- **Status Codes**: 200 OK, 400 Bad Request
- **Data Requirements**: 
  - `id` (int): The ID of the department.
  - `IFormCollection` collection.

### HomeController

#### GET: /Home
- **Description**: Displays the home page.
- **Status Codes**: 200 OK
- **Data Requirements**: None

#### GET: /Home/Privacy
- **Description**: Displays the privacy policy page.
- **Status Codes**: 200 OK
- **Data Requirements**: None

#### GET: /Home/Error
- **Description**: Displays the error page.
- **Status Codes**: 200 OK
- **Data Requirements**: None