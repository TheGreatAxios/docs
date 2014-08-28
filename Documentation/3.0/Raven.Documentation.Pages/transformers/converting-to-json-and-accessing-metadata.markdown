# Converting to JSON and accesing metadata

Entities passed to transformer can be converted to JSON using `AsDocument` method, there is also a possibility to access metadata for a specified object using `MetadataFor` method.

## AsDocument - converting to JSON

{CODE transformers_1@Transformers/Metadata.cs /}

{CODE transformers_2@Transformers/Metadata.cs /}

## MetadataFor - accessing metadata

{CODE transformers_3@Transformers/Metadata.cs /}

{CODE transformers_4@Transformers/Metadata.cs /}

## Related articles

- [Basic transformations](../transformers/basic-transformations)
- [Loading documents](../transformers/loading-documents)
- [Including documents](../transformers/including-documents)