// Generated by Microsoft TypeSpec

import {
  TodoItem,
  Standard4XxResponse,
  Standard5XxResponse,
  TodoFileAttachment,
  TodoUrlAttachment,
  ApiError,
} from "./index.js";

import { NoContentResponse } from "../typespec/http.js";

export interface TodoPage {
  /**
   * The items in the page
   */
  items: TodoItem[];

  /**
   * The number of items returned in this page
   */
  pageSize: number;

  /**
   * The total number of items
   */
  totalSize: number;

  /**
   * The limit to the number of items
   */
  limit?: number;

  /**
   * The offset to start paginating at
   */
  offset?: number;

  /**
   * A link to the previous page, if it exists
   */
  prevLink?: string;

  /**
   * A link to the next page, if it exists
   */
  nextLink?: string;
}

export interface TodoItemPatch {
  /**
   * The item's title
   */
  title?: string;

  /**
   * User that the todo is assigned to
   */
  assignedTo?: number | null;

  /**
   * A longer description of the todo item in markdown format
   */
  description?: string | null;

  /**
   * The status of the todo item
   */
  status?: "NotStarted" | "InProgress" | "Completed";
}

/** An interface representing the operations defined in the 'Todo.TodoItems.Attachments' namespace. */
export interface Attachments<Context = unknown> {
  list(
    ctx: Context,
    itemId: number,
  ): Promise<
    | TodoAttachmentPage
    | NotFoundErrorResponse
    | Standard4XxResponse
    | Standard5XxResponse
  >;

  createAttachment(
    ctx: Context,
    itemId: number,
    contents: TodoFileAttachment | TodoUrlAttachment,
  ): Promise<
    | NoContentResponse
    | NotFoundErrorResponse
    | Standard4XxResponse
    | Standard5XxResponse
  >;
}

export interface PaginationControls {
  /**
   * The limit to the number of items
   */
  limit?: number;

  /**
   * The offset to start paginating at
   */
  offset?: number;
}

export interface InvalidTodoItem extends ApiError {
  statusCode: 422;
}

export interface NotFoundErrorResponse {
  statusCode: 404;

  code: "not-found";
}

export interface TodoAttachmentPage {
  items: Array<TodoFileAttachment | TodoUrlAttachment>;
}

export const TodoPage = {
  toJsonObject(input: TodoPage): object {
    return {
      items: input.items,
      pageSize: input.pageSize,
      totalSize: input.totalSize,
      limit: input.limit,
      offset: input.offset,
      prevLink: input.prevLink,
      nextLink: input.nextLink,
    };
  },
  fromJsonObject(input: object): TodoPage {
    return {
      items: input["items"],
      pageSize: input["pageSize"],
      totalSize: input["totalSize"],
      limit: input["limit"],
      offset: input["offset"],
      prevLink: input["prevLink"],
      nextLink: input["nextLink"],
    };
  },
} as const;
