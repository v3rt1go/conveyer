# Inheritance

All fields should inherit from the UnitFieldBase abstract class which implements the IUnitField interface.

## IUnitField interface

The IUnitField interface implements the following properties:

### Meta properties

* **Id** - Gets the unique identifier of the unit in GUID format. _Default: new Guid()_
* **State** - Gets or sets the State of the field. _Default: Changed_
* **Type** - Gets the Type of the field. _Default: ShortText; Required true_
* **DisplayValue** - Gets or sets the display value of the field. The display value is used when showing a friendly name for the field in the Conveyer UI. _Required true_
* **HelpText** - Gets or sets the help text presented on the Conveyer UI for a specific UnitField.
* **ValidationRules** - Gets or sets the validation rules for the UnitField
* **AllowedValidations** - Gets the list of allowed validations based on the FieldType
* **SerializationRules** - Gets or sets the serialization rules for the UnitField
* **AllowedSerializers** - Gets or sets the list of allowed serialization rules for the UnitField
* **DisplayType** - Gets or sets the appearance details for the UnitField. _Default: SingleLine_
* **AllowedDisplayTypes** - Gets the list of allowed display types based on the FieldType. _Default: ShortText allowed UIs_
* **Version** - Gets or sets the version number of the field. Version number always starts at 0 and auto increments with each State change. _Default: 0_
* **CreatedAt** - Gets the date when the field has been created. _Default: new DateTime()_
* **CreatedBy** - Gets the GUID of the user who created the field. _Required: true_
* **UpdatedAt** - Gets or sets the date of the last time the field has been updated
* **UpdatedBy** - Gets or sets the GUID of the user who last updated the field

### Security properties

* **Access** - Gets or sets the access level of the field with other units. Possible values: Private, Public. _Default: Public_
* **BelongsTo** - Gets or sets the GUID of the unit that the field belongs to. Required: true

## UnitFieldBase abstract class

The abstract class implements the IUnitField base interface.
The abstract class is responsible for initializing the read-only properties, implements the constructors and the common methods for all the field types.

### Constructors

1. Parameterless constructor - should not exist/be callable from outside
1. CallerId and BelongsTo constructor - the bare minimum ctor.
1. CallerId, BelongsTo, Type, DisplayValue - the normal ctor that will be used when creating unit fields from the api
1. Full object ctor - This ctor should be private, for internal use

### Concrete methods



### Abstract methods

# Features

## Prerequisites

Unit fields are integral parts of a Unit. A unit field must always belong to a unit.
Before a unit field is created, a unit has to be defined.

Unit fields are always created by a registered user or super user. The callerId (the id of the registered user or system user) is always sent when creating a new field, along with the id of the unit the field belongs to.

## New unit field creation



