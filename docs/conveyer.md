# Convey.er (conveyer.io / conveyor.io)

A highly flexible and scalable micro-services oriented application(s) that allows interoperability and connectivity between very modular APIs that serve different purposes in order build and expose rich APIs (OData v4/Swagger) that can be used to do several tasks of an online nature, from simple communication of custom defined Data Transport Objects between various services.

Possible applications range from powering blogs, static site generators, e-commerce solutions, analytics, IoT applications etc. to simple comments or "like" button features.

**Basically anything that can consume a REST API endpoint and _optionally_ render HTML/CSS/JS.**

## Motivation

Most of the software data related tasks have become repetitive, filled with boilerplate or auto-generated code that is - simply put - boring to write and take time. We want to ~~remove~~ greatly reduce all this and allow our users to focus on the business side of their project.

We aim to allow our users to easily create data models and interactions between those models, using a simple but powerful ui. If needed a more advanced user can open an online editor
(_Monaco_) and code himself.

The data models can be enriched with existing services that cover most of the common use cases
when working with data and integrate with other internal or third-party APIs.

Finally, our users can group several data models and services to create a modular, independent unit that can be integrated in a new or existing app. Grouping several units together allows our users to build a fully functional, rich, data driven app.

## So ... what am I getting?

It depends on what you need. Probably most of the use cases will be for the browser and in this case you'll be getting a simple ```<template></template>``` block that you'll integrate into your app and see whatever you've built ~~magically~~ work.

You can also build a service that expects data. In this case you won't need a template to integrate with your existing UI, because you won't have one. You'll still be able to see and work with your data in whatever way you want using our client UI.

