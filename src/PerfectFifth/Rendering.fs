namespace P5

module Rendering =

    open Fable.Core
    open P5.Core
    open P5.DOM
    open Browser.Types

    type RenderMode =
        | P2D
        | WebGL

    type P5Renderer() =
        inherit P5Element<Unit>()

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

    [<Emit("$0.resizeCanvas($1, $2)")>]
    let resizeCanvas (p5: P5) (width: int) (height: int) : Unit = jsNative

    [<Emit("$0.resizeCanvas($1, $2, true")>]
    let resizeCanvasWithoutRedraw (p5: P5) (width: int) (height: int) : Unit = jsNative

    [<Emit("$0.createGraphics($1, $2)")>]
    let createGraphics (p5: P5) (width: int) (height: int) : P5 = jsNative

    [<Emit("$0.createGraphics($1, $2, 'webgl')")>]
    let createWebGLGraphics (p5: P5) (width: int) (height: int) : P5 = jsNative

    [<Emit("$0.setAttributes($1, $2)")>]
    let setAttribute (p5: P5) (key: string) (value: obj) : Unit = jsNative

    /// Pass an attribute set using an anonymous record or the result of Fable's
    /// createObj
    [<Emit("$0.setAttributes($1, $2)")>]
    let setAttributes (p5: P5) (obj: obj) : Unit = jsNative

    [<Emit("$0.noCanvas()")>]
    let noCanvas (p5: P5) : Unit = jsNative

    type BlendMode =
        | Blend
        | Darkest
        | Lightest
        | Difference
        | Multiply
        | Exclusion
        | Screen
        | Replace
        | Overlay
        | HardLight
        | SoftLight
        | Dodge
        | Burn
        | Add
        | Remove
        | Subtract

    let internal rawBlendMode (mode: BlendMode) : string =
        match mode with
        | Blend -> "source-over"
        | Darkest -> "darken"
        | Lightest -> "lighten"
        | Difference -> "difference"
        | Multiply -> "multiply"
        | Exclusion -> "exclusion"
        | Screen -> "screen"
        | Replace -> "copy"
        | Overlay -> "overlay"
        | HardLight -> "hard-light"
        | SoftLight -> "soft-light"
        | Dodge -> "color-dodge"
        | Burn -> "color-burn"
        | Add -> "lighter"
        | Remove -> "destination-out"
        | Subtract -> "subtract"

    [<Emit("$0.blendMode($1)")>]
    let private blendMode_ (p5: P5) (blendMode: string) : Unit = jsNative

    let blendMode (p5: P5) (blendMode: BlendMode) : Unit = blendMode_ p5 (rawBlendMode blendMode)

    [<Emit("$0.drawingContext")>]
    let drawingContext (p5: P5) : CanvasRenderingContext2D = jsNative
