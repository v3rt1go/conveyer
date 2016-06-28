# Unit Overview - COPIED FROM CONTENTFUL

**The unit represents an entity that your module will be working with.**

A unit has several sections, each with its clearly defined purpose:

* **The metadata section** - this is for internal use, versioning, internal identifier, source (if cloned), returned data type, module linking etc.
* **The service hooks section** - used to hook services and events that apply unit wide.
* **The security section** - used to control access modifiers (public/private), user permissions etc.
* **The fields section** - this is where the user does most of the work for a unit, defining the fields to store data in.

The bulk of the unit consists of one or more fields of different or same content types. Field data is stored in the **field section** of the unit.

Each unit defines which _fields_ an entry of that type is supposed to have. You can have **up to 50 fields** in your unit.

**A field has:**

* a name,
* a stored/returned data type
* metadata, like validations, localization info etc.
* appearance details for the UI
* service hooks - field level service hooks can be used to hook up filtering services, pagination etc.

The data type defines what kind of content the field values store, e.g. a short text or an integer number.

One notable data type is _link_, it enables the modeling of relationships between entries and assets. For example, you can have a _category_ content type and link all blog posts belonging to that category to it, so that you can easily retrieve them.

~~Each field can also be localized into different locales, by providing a different value for each of them.~~

## Building relations between units (Links)

