namespace P5

module Rendering =

    open Fable.Core
    open P5.Core

    type P5Graphics = class end

    type RenderMode =
        | P2D
        | WebGL

    let private rawRenderMode renderMode =
        match renderMode with
        | P2D -> "p2d"
        | WebGL -> "webgl"

    [<Emit("$0.createCanvas($1, $2)")>]
    let createCanvas (p5: P5) (width: int) (height: int) : Unit = jsNative

    [<Emit("$0.createCanvas($1, $2, $3)")>]
    let private createCanvasWithMode_ (p5: P5) (width: int) (height: int) (mode: string) : Unit = jsNative

    let createCanvasWithMode (p5: P5) (width: int) (height: int) (mode: RenderMode) : Unit =
        createCanvasWithMode_ p5 width height (rawRenderMode mode)

    let createWebGLCanvas (p5: P5) (width: int) (height: int) : Unit =
        createCanvasWithMode p5 width height WebGL

    /// TODO: noRedraw
    [<Emit("$0.resizeCanvas($1, $2)")>]
    let resizeCanvas (p5: P5) (width: int) (height: int) : Unit = jsNative

    /// TODO: renderer
    [<Emit("$0.createGraphics($1, $2)")>]
    let createGraphics (p5: P5) (width: int) (height: int) : P5 = jsNative

    /// TODO: is using obj fine here, since the value can be basically anything?
    /// TODO: what about different value types?
    [<Emit("$0.setAttributes($1, $2)")>]
    let setAttributes (p5) (key: string) (value: obj) : Unit = jsNative
