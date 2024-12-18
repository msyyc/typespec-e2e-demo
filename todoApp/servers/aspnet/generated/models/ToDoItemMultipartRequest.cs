// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// <auto-generated />

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Todo.Service.Models
{

    public partial class ToDoItemMultipartRequest
    {
        public HttpPartTodoItem Item { get; set; }

        public HttpPartTodoFileAttachment[] Attachments { get; set; }


    }
}
