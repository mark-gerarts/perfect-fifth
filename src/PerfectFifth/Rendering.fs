namespace P5

module Rendering =

    open Fable.Core
    open P5.Core

    type RenderMode =
        | P2D
        | WebGL

    let private rawRenderMode renderMode =
        match renderMode with
        | P2D -> "p2d"
        | WebGL -> "webgl"

    [<Emit("$0.createCanvas($1, $2)")>]
    let createCanvasAndReturn (p5: P5) (width: int) (height: int) : P5 = jsNative

    [<Emit("$0.createCanvas($1, $2, $3)")>]
    let private createCanvasWithModeAndReturn_ (p5: P5) (width: int) (height: int) (mode: string) : P5 = jsNative

    let createCanvasWithModeAndReturn (p5: P5) (width: int) (height: int) (mode: RenderMode) : P5 =
        createCanvasWithModeAndReturn_ p5 width height (rawRenderMode mode)

    let createWebGLCanvasAndReturn (p5: P5) (width: int) (height: int) : P5 =
        createCanvasWithModeAndReturn p5 width height WebGL

    let createCanvas (p5: P5) (width: int) (height: int) : Unit =
        createCanvasAndReturn p5 width height |> ignore

    let createCanvasWithMode (p5: P5) (width: int) (height: int) (mode: RenderMode) : Unit =
        createCanvasWithModeAndReturn p5 width height mode |> ignore

    let createWebGLCanvas (p5: P5) (width: int) (height: int) : Unit =
        createWebGLCanvasAndReturn p5 width height |> ignore

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
