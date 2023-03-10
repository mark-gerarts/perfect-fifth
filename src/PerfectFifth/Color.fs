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

    let private emitColorFunction (p5: P5) (method: string) (color: Color) : 'a =
        match color with
        | RGB(r, g, b) -> emit3 p5 method r g b
        | RGBA(r, g, b, a) -> emit4 p5 method r g b a
        | Grayscale intensity -> emit1 p5 method intensity
        | GrayscaleA(intensity, alpha) -> emit2 p5 method intensity alpha
        | Name name -> emit1 p5 method name
        | Values values -> emit1 p5 method values
        | P5Color color -> emit1 p5 method color

    let color (p5: P5) (color: Color) : P5Color = emitColorFunction p5 "color" color

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

    let alpha (p5: P5) (color: Color) : float = emitColorFunction p5 "alpha" color

    let blue (p5: P5) (color: Color) : float = emitColorFunction p5 "blue" color

    let brightness (p5: P5) (color: Color) : float = emitColorFunction p5 "brightness" color

    type ColorMode =
        | ModeRGB
        | ModeHSL
        | ModeHSB

    let private rawColorMode (colorMode: ColorMode) =
        match colorMode with
        | ModeRGB -> "rgb"
        | ModeHSL -> "hsl"
        | ModeHSB -> "hsb"

    [<Emit("$0.colorMode($1)")>]
    let private colorMode_ (p5: P5) (colorMode: string) : Unit = jsNative

    /// TODO: colorMode with specific max values (and alpha)
    let colorMode (p5: P5) (colorMode: ColorMode) : Unit = colorMode_ p5 (rawColorMode colorMode)

    [<Emit("$0.colorMode($1, $2)")>]
    let private colorModeMaxAll_ (p5: P5) (colorMode: string) (max: float) : Unit = jsNative

    let colorModeMaxAll (p5: P5) (colorMode: ColorMode) (max: float) : Unit =
        colorModeMaxAll_ p5 (rawColorMode colorMode) max
