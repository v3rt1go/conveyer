# Exposed APIs overview - COPIED FROM CONTENTFUL!

Convey.er exposes a total of 5 APIs that can be consumed by our users to effectively build, distribute preview and manage their data and modules.

1. Content Delivery API
2. Content Management API
3. Preview API
4. Media API
5. Security API

## The Content Delivery API (CDA)

Is a **read-only** API for retrieving content from Convey.er units. All content - both JSON and binary - is fetched from the edge server closes to the user's location by using the Azure CDN. As a content developer, our users have the possibility to control the caching level of this API's responses.

Content is delivered as JSON data. Images, videos and other media are delivered as files via **streams** of data.

All content is hosted on geo-redundant data stores using the Azure cloud. This greatly improves availability of content.

## The Content Management API (CMA)

It is a read-write API for managing your data models and content. This API is highly secured and allows you to create, edit and manage data models and content in the cloud and publish it anywhere via the API.

It covers several use cases, such as:

* Automatic imports from different CMSes like WordPress or Drupal
* Integration with other backend systems, such as an e-commerce shop
* Building custom editing experiences.

> Note: The Content Management API can also be used to retrieve content. However, it is used to only manage content, so the entirety of items will be retrieved (i.e. all unpublished content).

> Additionally Data Models / Units marked as Private are also viewable via the CMA API.

The calls to the CMA API are not cacheable by default and are optimized for data transport resiliency and security, not speed and high availability.

## The Preview API

Is a variant of the CDA for previewing your content before you deliver it to your customers, while it's still in a "Draft" state.

You use the Preview API in combination with a "preview" deployment of your website (or a "preview" build of your mobile app) that allows content managers and authors to view their work in-context, as though it had been published.

This API uses a "preview" access token to allow you to view unpublished content as though it were being delivered by the CDA.

## Media API

With the Images API you can resize and crop images, change their background color and convert them to different formats – PNG→JPG, for instance.

Using our backend for these transformations lets you upload high-quality assets, deliver exactly what your app needs, and still get all the benefits of our caching CDN.

Media assets can be - and typically are - delivered via the CDA API which is enough for most general use cases. The Media API is designed to give more control over the way media assets are stored, formatted, degraded, delivered etc.

General use cases for this API is when building rich media modules like image galleries, light-weight video streaming services or PDF builders.

## Security API

TBD

Used to give access to other users to the organisational/group account. Can control permissions for modules, resources, apps and even private/public units granted to users of the same account.

Additionally it handles security/permissions considerations when sharing resources between convey.er users that do not belong to the same organisation.

