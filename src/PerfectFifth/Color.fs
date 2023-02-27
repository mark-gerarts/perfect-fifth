namespace P5

module Color =

    open Fable.Core
    open P5.Core
    open P5.Util

    // TODO: actual p5.Color class
    type Color =
        | RGB of r: int * g: int * b: int
        | RGBA of r: int * g: int * b: int * a: int
        | Grayscale of intensity: int
        | GrayscaleA of intensity: int * alpha: int
        | Name of string
        | Values of int seq

    let private emitColorFunction (p5: P5) (method: string) (color: Color) : Unit =
        match color with
        | RGB(r, g, b) -> emit3 p5 method r g b
        | RGBA(r, g, b, a) -> emit4 p5 method r g b a
        | Grayscale intensity -> emit1 p5 method intensity
        | GrayscaleA(intensity, alpha) -> emit2 p5 method intensity alpha
        | Name name -> emit1 p5 method name
        | Values values -> emit1 p5 method values

    let background (p5: P5) (color: Color) : Unit = emitColorFunction p5 "background" color

    let fill (p5: P5) (color: Color) : Unit = emitColorFunction p5 "fill" color

    [<Emit("$0.noFill()")>]
    let noFill (p5: P5) : Unit = jsNative

    let stroke (p5: P5) (color: Color) : Unit = emitColorFunction p5 "stroke" color

    [<Emit("$0.noStroke()")>]
    let noStroke (p5: P5) : Unit = jsNative
