Easy Start
===========================

This project is designed to provide a robust starting point with commonly used features for any modern web application. It includes backend and frontend implementations for features like user authentication, account confirmation, translation, and more.

Table of Contents
-----------------

*   [Overview](#overview)

*   [Features](#features)

*   [Technologies](#technologies)

*   [Setup](#setup)

*   [Usage](#usage)

*   [Folder Structure](#folder-structure)

*   [Contributing](#contributing)

*   [License](#license)


Overview
--------

This starter kit offers a template with reusable, production-ready features for web applications. It is built with the latest versions of .NET Core for the backend and Angular for the frontend, following industry standards and best practices.

Features
--------

1.  **Authorization & Authentication**

    *   JWT-based authentication.

    *   Role-based access control.

    *   Token refresh.

2.  **User Account Management**

    *   Account creation with validation.

    *   Email verification for new users.

    *   Password reset and update features.

3.  **Localization and Translation**

    *   Supports multiple languages.

    *   Easy to extend with new translations.

4.  **Other Common Utilities**

    *   Rate limiting for enhanced security.

    *   Caching for improved performance.


Technologies
------------

### Backend

*   .NET Core (latest version)

*   Entity Framework Core

*   JWT for authentication

*   ASP.NET Identity for user management


### Frontend

*   Angular (latest version)

*   Angular Material for UI components

*   ngx-translate for translation


Setup
-----

### Prerequisites

*   [.NET Core SDK](https://dotnet.microsoft.com/download) (latest version)

*   [Node.js](https://nodejs.org/) and npm (latest version)

*   Angular CLI


### Installation

1.  ```bash 
    git clone https://github.com/Furqat-DevDo/easy-start.git
    cd easy-start-kit

2.  **Backend Setup**:

    *  ```bash 
       cd backend

    *   ```bash
        dotnet restore
        dotnet build

    *   ```bash
        dotnet ef database update

3.  **Frontend Setup**:

    *   ```bash
        cd ../frontend

    *   ```bash
        npm install


Usage
-----

1.  ```bash
    cd backend dotnet run

2.  ```bash
    cd ../frontend ng serve


Access the app at http://localhost:4200.

Folder Structure
----------------
    easy-start/
    ├── backend/                 # .NET Core API
    │   ├── Controllers/         # API Controllers
    │   ├── Models/              # Database models
    │   └── Services/            # Business logic
    └── frontend/                # Angular app
    ├── src/
    │   ├── app/
    │   ├── assets/          # Translation files, images, etc.
    │   └── environments/    # Environment configuration


Contributing
------------

Contributions are welcome! Please submit issues or pull requests for enhancements.

## License

This project is licensed under the GNU General Public License v3.0 (GPL-3.0).

Under the terms of GPL-3.0, you are free to use, modify, and distribute this project under the same license. Any derivative works based on this project must also remain open source under GPL-3.0.

### Commercial License

#### If you wish to use this project in a closed-source or commercial product, please contact me at **furqata93@gmail.com**  to discuss commercial licensing options.
