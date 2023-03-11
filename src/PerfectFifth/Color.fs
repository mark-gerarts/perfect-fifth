namespace P5

module Color =

    open Fable.Core
    open P5.Core
    open P5.Util

    [<Import("Color", from = "p5")>]
    type P5Color =
        member _.setRed(r: float) = jsNative

        member _.setGreen(g: float) = jsNative

        member _.setBlue(b: float) = jsNative

        member _.setAlpha(a: float) = jsNative

        member _.toString() : string = jsNative

        [<Emit("$0.toString($1)")>]
        member _.toStringf(format: string) : string = jsNative

    type Color =
        | RGB of r: int * g: int * b: int
        | RGBA of r: int * g: int * b: int * a: int
        | Grayscale of intensity: int
        | GrayscaleA of intensity: int * alpha: int
        | Name of string
        | Values of int seq
        | P5Color of P5Color

    let private emitColorFunction (p5: P5) (method: string) (color: Color) : Unit =
        match color with
        | RGB(r, g, b) -> emit3 p5 method r g b
        | RGBA(r, g, b, a) -> emit4 p5 method r g b a
        | Grayscale intensity -> emit1 p5 method intensity
        | GrayscaleA(intensity, alpha) -> emit2 p5 method intensity alpha
        | Name name -> emit1 p5 method name
        | Values values -> emit1 p5 method values
        | P5Color color -> emit1 p5 method color

    [<Emit("$0.color($1, $2, $3)")>]
    let private colorRGB (p5: P5) (r: int) (g: int) (b: int) : P5Color = jsNative

    [<Emit("$0.color($1, $2, $3, $4)")>]
    let private colorRGBA (p5: P5) (r: int) (g: int) (b: int) (alpha: int) : P5Color = jsNative

    [<Emit("$0.color($1)")>]
    let private colorGrayscale (p5: P5) (intensity: int) : P5Color = jsNative

    [<Emit("$0.color($1, $2)")>]
    let private colorGrayscaleA (p5: P5) (intensity: int) (alpha: int) : P5Color = jsNative

    [<Emit("$0.color($1)")>]
    let private colorName (p5: P5) (name: string) : P5Color = jsNative

    [<Emit("$0.color($1)")>]
    let private colorValues (p5: P5) (values: int seq) : P5Color = jsNative

    [<Emit("$0.color($1)")>]
    let private colorP5Color (p5: P5) (color: P5Color) : P5Color = jsNative

    let color (p5: P5) (color: Color) : P5Color =
        match color with
        | RGB(r, g, b) -> colorRGB p5 r g b
        | RGBA(r, g, b, a) -> colorRGBA p5 r g b a
        | Grayscale intensity -> colorGrayscale p5 intensity
        | GrayscaleA(intensity, alpha) -> colorGrayscaleA p5 intensity alpha
        | Name name -> colorName p5 name
        | Values values -> colorValues p5 values
        | P5Color color -> colorP5Color p5 color

    let background (p5: P5) (color: Color) : Unit = emitColorFunction p5 "background" color

    let fill (p5: P5) (color: Color) : Unit = emitColorFunction p5 "fill" color

    [<Emit("$0.noFill()")>]
    let noFill (p5: P5) : Unit = jsNative

    let stroke (p5: P5) (color: Color) : Unit = emitColorFunction p5 "stroke" color

    [<Emit("$0.noStroke()")>]
    let noStroke (p5: P5) : Unit = jsNative

    /// TODO: clearWebgl
    [<Emit("$0.clear()")>]
    let clear (p5: P5) : Unit = jsNative
