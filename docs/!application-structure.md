# Modules - REVIEW

Each user has the possibility of defining one or more modules _(spaces/resource groups/containers/units)_. Inside each module the user has the possibility to define several data models _(IPrivateUnit?)_, and mark them as private (to be used only inside the module, and never exposed) or public – and they will act as Data Transport Objects _(IUnit?)_ – will be exposed to other modules that will be connected.

Besides models, inside a module the user can create various methods to work with the module objects, or data that is passed to the module, and an API interface that will be exposed by the module.

**Each module should serve a single purpose.**

The user can use the module as stand-alone, or group several modules together to create a resource.

Modules have two ways of communicating with the exterior: They can either communicate using their exposed public API, or, usually when communicating between each other, using a Pub/Sub mechanism or messaging queue. _(Observer Pattern?)_

## Example:

1. Module 1: Content Management – manages articles and posts
2. Module 2: Comments management
3. Module 3: Photo gallery
4. Module 4: User manager
5. Module 5: Media assets management
6. Module 6: Module 1 defined for Products and categories DTOs
7. Module 7: Order and cart management
8. Module 8: Payment gateway
9. Module 9: Social media
10. Module 10: Analytics

**Modules 1 – 5 when set together they create a Blog Application resource.**

Using the _Blog Application_ resource, a user can add modules 6,7,8 to create a simple e-commerce application and name it _Shop Resource_.
Furthermore, to the Shop Resource a user can add modules 9 and 10 and create a fully fledge e-commerce app named _MyEcommWebsite Resource_.

# Resources - REVIEW

Resources are usually groups of modules that form together an application. Resources, by their nature serve multiple purposes and expose a unified API that gives data access, to the clients consuming it, to all the APIs of the modules composing the resource.

Other Modules and Resources can consume an existing resource to fetch or send data to it.

## Example:

A uses already has defined a _Mobile Resource_ application that has various modules who compose the user’s mobile application. The user wants to extend his existing _Mobile Resource_ with an API that is going to present products to the users using the mobile application.

He can link the _Shop Resource_ to the _Mobile Resource_, create a new Module for the Mobile resource that will consume the data exposed by the _Shop Resource_ and use that data to populate the mobile pages with existing, real-time products. _(Pub/Sub - Observer Pattern?)_

# Service Modules - REVIEW

Service modules are advanced modules that run on a very low abstraction level, many times behind the existing user defined modules, and are usually developed by us.

## Example:

**Data Type Definition Service** – This service model handles creating the data models that will be used as models inside the user defined modules. It receives that data as JSON with fields and field types, and creates the real models (or JSON schemas) in the user space.

> -	We should try both the serialization/deserialization approach for creating the user defined models or leveraging the docker containers, the Monaco editor and Roslyn, spin up dedicated applications for the clients that will create actual strongly typed models for our users.
-	Deserialize the JSON document into C# dynamic objects. Find a way to handle user defined field validation rules .
-	Use ExpandoObject and JSON.Net to handle these tasks – possible solution

Other examples of _Service Modules_ include:

- HTTPService
- Authentication Service
- Caching Service
- DataStore Service
- Media Assets delivery service





