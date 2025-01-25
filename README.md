gRPC 是一种高性能、开源的远程过程调用（RPC）框架，基于 HTTP/2 协议，支持双向流、头部压缩等特性。它默认使用 Protocol Buffers（Protobuf）作为接口定义语言（IDL）和数据序列化格式，适用于微服务、实时通信等场景。
在 .NET Core（.NET 8）中，gRPC 提供了原生的支持，开发者可以轻松创建 gRPC 服务端和客户端，并将其集成到 Web API 或其他应用中。
该项目围绕以下几个方面介绍如何在 .NET Core (.NET 8) 中使用 gRPC：1. 创建 gRPC 服务端，2. 创建 gRPC 客户端，3. 在 Web API 中集成 gRPC
