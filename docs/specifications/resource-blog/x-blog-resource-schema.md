# Overview

The blog resource consists of several modules that create a basic blogging functionality for a website.

## Common properties for all IUnits

### Meta properties

* Id
* State - enum (Published, Changed, Draft, Archived)
* Version
* Created At
* Created By
* Updated At
* Updated By
* Display Value

### Security properties

* Access - enum (Private, Public)
* Belongs To - owned by #account

### Service hooks

> TBD

## Common properties for all IUnitFields

### Meta properties

* Id
* Display Value
* State - enum (Published, Changed, Draft, Archived) or (Enabled, Changed, Clean, Archived)
* Version
* Validation details (required, regex, min, max, type, accepted types, format etc.)
* Serialization / Deserialization details
* Appearance details - ui specific preferences
* Created At
* Created By
* Updated At
* Updated By

### Security properties

* Access - enum (Private, Public)
* Belongs To - the id of the unit which owns the field

### Service hooks

> TBD

## Publication module

The publication module handles article content management and publication to the database.

### Post unit

The post unit is a public data transfer model that handles the post content.

#### Data Fields

* Title
* Slug / Permalink
* Body
* Featured Image
* Publish Date
* Allow Comments

#### Reference Fields

* Author - references Author unit from Authentication module (_n-1_)
* Tags - linked list field, references Tag unit form Publication module (_n-n_)
* Category - references Category unit from Routing module (_n-1_/_n-n_?)

> I'm not sure if tags should be a linked list or a data field that contains a string list and is stored at the post document level. It really depends on the type of queries the users will run the data store the users will use. If using a relation data store it's better to keep the tags as a separate entity that is referenced by the post. If using a document store is better to keep the tag as a list included in the post document.

> I think the best option would be to have the tag as a separat unit that serves a tagging purpose, and includes all the necessary metadata to be a standalone entity. Inside the Post JSON document store a collection of tags that include the $id and $name of the tag. When deserializing, deserialize to an IObservableCollection that for each change will update the linked tag entity also.

### Tag unit

The tag unit is a public/private DTO model that acts as a light category to structure post units. A tag belongs to multiple posts and a post can have multiple tags.

#### Data Fields

* Name
* Description
* Slug / Permalink
* Is Navigation

#### Reference Fields

* Category - A tag can reference a category unit from the Routing module to create a blog route. (_1-1_)


## Routing module
The routing module handles the pages, categories and routes of the blog

### Category unit
The category unit handles grouping posts in categories and also creating dynamic routes for post collections.

#### Data Fields

* Title
* Slug / Permalink
* Featured Image
* Icon
* Description
* Short description - editing disabled field with a service hook to extract the first paragraph of the description field

#### Reference Fields

* Posts - a linked list that will store a collection of post ids and slugs.

> As with the Tag unit discussion, I'm not sure if it's ok or necessary to store relations on both entity types (Posts and Category). The best place of course depends on the types of queries that will run, but considering that most of the data stores will be document based it's probably better to store relations on just one document type. Post in this case

## Authentication module
The authentication module handles user authentication and authorization and Author entity relationship to the publication module.

> The authentication module will have a few extra meta properties and default service hooks besides the general applicable ones. These extra properties will handle security specific concerns and audit concerns. TBD!

### Author unit

The author unit represent the user entity for the purpose of the blog resource. It is an implementation of the User unit which will be later defined.

Since it is part of the Authentication module it has permissions restrictions and it's actions are fully audited.

#### Data Fields

* First Name
* Last Name
* Display Name
* Email
* Bio
* Website
* Twitter
* Facebook
* GitHub
* Profile Photo

#### Reference Fields

* Created Entries - a linked list of **polymorphic associations** that will store references (objects with _identification info_) of all the entities created by the author. This will server querying, auditing and security purposes.

> Identification info - Each unit will have 1 or more fields that will serve to find the specific entity in the unit collection. The identification info will be stored as a JObject when working with linked lists and inside JSON document collections. The JObject could contain the $id and slug of a post, that can be used to find the post entity indifferent of the type of data store we are working with.

### User unit

> TBD