# The Convey.er Data Model

When a user signs-up and accesses the Convey.er application he has basically entered inside a factory, he's sitting at the assembly line.

The _Dashboard_ gives the user a broad overview of all the data units, modules, resources, apps and services he has access to or has defined.

Initially the space is empty. Imagine a simple assembly line with an empty straight conveyor belt. This straight conveyor belt is called a **Module**. When the user first signs up he is automatically provisioned with a default module (_Simple comment widget?_) to better understand how the application works.

## The convey.er belt (Service)

TBD

## The unit (Data Model)

Individual data models (units) are stored in either entries, which represent textual or structural information, or assets, which handle binary files, like images, videos or documents.

Each piece has a set of attributes, which we call _fields_. Assets have three fixed fields, name, description and the attached file, but the structure of entries in your space is defined in the data model.

## The module (Functional Repository)

A **module** is composed of several **units**. Units are _Data Models_, some are private and can only be accessed from inside this module while others are public and can be accessed / passed to/by other modules.

It is perfectly fine to have a module that is composed of only private units. This will make the module private and isolated - so you won't be able to extend it further with other modules - but if it serves your purpose, than it's ok.

## Connecting modules (Resources)

Connecting several modules together is like extending your assembly line with other conveyor belts. You will no longer have one straight conveyor belt, you will have several belts that fork, turn or go straight to meet your purpose.

By grouping several modules together you are creating a **Resource**.

> Remember that private modules (modules composed of only private units) cannot be connected with other modules.

## Connecting resources (Apps)

Once you have several resources defined you can connect them to create an _App_. Imagine the app as a fully functional assembly line that handles the whole process from raw material and parts to the finished product. This "assembly line" takes up all the room.

## Rooms / Spaces (Projects)

A user can have multiple rooms / spaces, each separated, with it's own security rules, API keys and permissions. This is a good way of separating different "projects" from each other.

It is possible, however, to fork/import/copy/link units/modules/resources from another existing room/space.