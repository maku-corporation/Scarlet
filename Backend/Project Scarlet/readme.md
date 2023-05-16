### Core Layer (shared library)
This accessory layer is also optional, it is a module to organize common interfaces and utility classes and functions that do not belong to the Domain Layer but must be made available widely to the application.

### Domain Layer (business rules)
Contains core concepts and rules that are independent of infrastructure and presentation. It represents state and behavior that models the application. It contains the following concepts:

- Entities
- Business Logic (Use Cases, Validators, Exceptions)
- Data Repository Interfaces
- Service Interfaces

### Data Layer (persistence)
Contains persistence infrastructure implementations and adapters. It is likely to contain:

- Data models
- Model/Entity mappers
- Data Repository Implementations (persistence)

### Services Layer (external services)
This is an optional layer to model external dependencies beyond data persistence, such as access to web services, remote devices, hardware, etc. This layer would be omitted when the application does not depend on external services, becoming a 3+2 Layered Architecture variant.


### Presentation Layer (UI)
This is the layer to present information and interact with the user. It depends only on types defined in inner layers, mostly on Domain Use Cases, Entities and Exceptions. It is the “magic” of interfaces and implementation injections that make it possible for this layer to use at runtime code provided by Data and Service layers.

The inner organization of this is layer is very framework dependent, the main concept here is that no other layer depends on this one and multiple Presentation alternatives may be implemented and run independently. For example, the same application may offer a Web UI, a Mobile UI and a Desktop UI all using the same Domain Use Cases.


###### References
-  https://medium.com/@nogueira.cc/4-2-layered-architecture-313329082989
