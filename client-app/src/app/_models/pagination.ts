import { Employee } from "./employee.model";

export interface Pagination {
  pageIndex: number;
  pageSize: number;
  count: number;
  data: Employee[];
}