namespace P5

module Rendering =

    open Fable.Core
    open P5.Core

    /// TODO: renderer (P2D/webgl) + return type
    [<Emit("$0.createCanvas($1, $2)")>]
    let createCanvas (p5: P5) (width: int) (height: int) : Unit = jsNative

    /// TODO: noRedraw
    [<Emit("$0.resizeCanvas($1, $2)")>]
    let resizeCanvas (p5: P5) (width: int) (height: int) : Unit = jsNative

    /// TODO: renderer
    [<Emit("$0.createGraphics($1, $2)")>]
    let createGraphics (p5: P5) (width: int) (height: int) : P5 = jsNative
