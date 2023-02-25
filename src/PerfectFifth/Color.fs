namespace P5

module Color =

    open Fable.Core
    open P5.Core

    type Color =
        | RGB of r: int * g: int * b: int
        | Grayscale of intensity: int

    [<Emit("$0.background($1, $2, $3)")>]
    let private backgroundRgb (p5: P5) (r: int) (g: int) (b: int) : Unit = jsNative

    [<Emit("$0.background($1)")>]
    let private backgroundGrayscale (p5: P5) (intensity: int) : Unit = jsNative

    let background (p5: P5) (color: Color) : Unit =
        match color with
        | RGB(r, g, b) -> backgroundRgb p5 r g b
        | Grayscale intensity -> backgroundGrayscale p5 intensity
