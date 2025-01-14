// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Todo;

namespace Todo.Models
{
    /// <summary></summary>
    public partial class TodoPagePagination : IJsonModel<TodoPagePagination>
    {
        internal TodoPagePagination()
        {
        }

        void IJsonModel<TodoPagePagination>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<TodoPagePagination>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TodoPagePagination)} does not support writing '{format}' format.");
            }
            writer.WritePropertyName("pageSize"u8);
            writer.WriteNumberValue(PageSize);
            writer.WritePropertyName("totalSize"u8);
            writer.WriteNumberValue(TotalSize);
            if (Optional.IsDefined(PrevLink))
            {
                writer.WritePropertyName("prevLink"u8);
                writer.WriteStringValue(PrevLink.AbsoluteUri);
            }
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink.AbsoluteUri);
            }
            if (options.Format != "W" && _additionalBinaryDataProperties != null)
            {
                foreach (var item in _additionalBinaryDataProperties)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
                    writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        TodoPagePagination IJsonModel<TodoPagePagination>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        /// <param name="reader"> The JSON reader. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual TodoPagePagination JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<TodoPagePagination>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TodoPagePagination)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTodoPagePagination(document.RootElement, options);
        }

        internal static TodoPagePagination DeserializeTodoPagePagination(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int pageSize = default;
            int totalSize = default;
            Uri prevLink = default;
            Uri nextLink = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("pageSize"u8))
                {
                    pageSize = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("totalSize"u8))
                {
                    totalSize = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("prevLink"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    prevLink = new Uri(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("nextLink"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextLink = new Uri(prop.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new TodoPagePagination(pageSize, totalSize, prevLink, nextLink, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<TodoPagePagination>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<TodoPagePagination>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TodoPagePagination)} does not support writing '{options.Format}' format.");
            }
        }

        TodoPagePagination IPersistableModel<TodoPagePagination>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        /// <param name="data"> The data to parse. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual TodoPagePagination PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<TodoPagePagination>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeTodoPagePagination(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TodoPagePagination)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TodoPagePagination>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <param name="todoPagePagination"> The <see cref="TodoPagePagination"/> to serialize into <see cref="BinaryContent"/>. </param>
        public static implicit operator BinaryContent(TodoPagePagination todoPagePagination)
        {
            if (todoPagePagination == null)
            {
                return null;
            }
            return BinaryContent.Create(todoPagePagination, ModelSerializationExtensions.WireOptions);
        }

        /// <param name="result"> The <see cref="ClientResult"/> to deserialize the <see cref="TodoPagePagination"/> from. </param>
        public static explicit operator TodoPagePagination(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeTodoPagePagination(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
