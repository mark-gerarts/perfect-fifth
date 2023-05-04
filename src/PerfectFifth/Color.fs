namespace P5

module Color =

    open Fable.Core
    open P5.Core
    open P5.Util

    type P5Color =
        [<Emit("$0.setRed($1)")>]
        member _.setRed(r: float) : Unit = jsNative

        [<Emit("$0.setGreen($1)")>]
        member _.setGreen(g: float) : Unit = jsNative

        [<Emit("$0.setBlue($1)")>]
        member _.setBlue(b: float) : Unit = jsNative

        [<Emit("$0.setAlpha($1)")>]
        member _.setAlpha(a: float) : Unit = jsNative

        [<Emit("$0.toString()")>]
        member _.toString() : string = jsNative

        [<Emit("$0.toString($1)")>]
        member _.toStringf(format: string) : string = jsNative

    type Color =
        | RGB of r: float * g: float * b: float
        | RGBA of r: float * g: float * b: float * a: float
        | Grayscale of intensity: float
        | GrayscaleA of intensity: float * alpha: float
        | Name of string
        | Values of float seq
        | P5Color of P5Color

    let internal emitColorFunction (p5: P5) (method: string) (color: Color) : 'a =
        match color with
        | RGB(r, g, b) -> emit3 p5 method r g b
        | RGBA(r, g, b, a) -> emit4 p5 method r g b a
        | Grayscale intensity -> emit1 p5 method intensity
        | GrayscaleA(intensity, alpha) -> emit2 p5 method intensity alpha
        | Name name -> emit1 p5 method name
        | Values values -> emit1 p5 method values
        | P5Color color -> emit1 p5 method color

    let color (p5: P5) (color: Color) : P5Color = emitColorFunction p5 "color" color

    let internal ensureP5Color (p5: P5) (c: Color) : P5Color =
        match c with
        | P5Color c -> c
        | c -> color p5 c

    let background (p5: P5) (color: Color) : Unit = emitColorFunction p5 "background" color

    let fill (p5: P5) (color: Color) : Unit = emitColorFunction p5 "fill" color

    [<Emit("$0.noFill()")>]
    let noFill (p5: P5) : Unit = jsNative

    let stroke (p5: P5) (color: Color) : Unit = emitColorFunction p5 "stroke" color

    [<Emit("$0.noStroke()")>]
    let noStroke (p5: P5) : Unit = jsNative

    [<Emit("$0.clear()")>]
    let clear (p5: P5) : Unit = jsNative

    [<Emit("$0.clear($1, $2, $3, $4)")>]
    let clearWebgl (p5: P5) (r: float) (g: float) (b: float) (a: float) : Unit = jsNative

    let alpha (p5: P5) (color: Color) : float =
        ensureP5Color p5 color |> P5Color |> emitColorFunction p5 "alpha"

    let blue (p5: P5) (color: Color) : float =
        ensureP5Color p5 color |> P5Color |> emitColorFunction p5 "blue"

    let green (p5: P5) (color: Color) : float =
        ensureP5Color p5 color |> P5Color |> emitColorFunction p5 "green"

    let red (p5: P5) (color: Color) : float =
        ensureP5Color p5 color |> P5Color |> emitColorFunction p5 "red"

    let hue (p5: P5) (color: Color) : float =
        ensureP5Color p5 color |> P5Color |> emitColorFunction p5 "hue"

    let brightness (p5: P5) (color: Color) : float =
        ensureP5Color p5 color |> P5Color |> emitColorFunction p5 "brightness"

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

    let colorMode (p5: P5) (colorMode: ColorMode) : Unit = colorMode_ p5 (rawColorMode colorMode)

    [<Emit("$0.colorMode($1, $2)")>]
    let private colorModeMaxAll_ (p5: P5) (colorMode: string) (max: float) : Unit = jsNative

    let colorModeMaxAll (p5: P5) (colorMode: ColorMode) (max: float) : Unit =
        colorModeMaxAll_ p5 (rawColorMode colorMode) max

    [<Emit("$0.colorMode($1, $2, $3, $4)")>]
    let private colorModeMax_ (p5: P5) (colorMode: string) (max1: float) (max2: float) (max3: float) : Unit = jsNative

    let colorModeMax (p5: P5) (colorMode: ColorMode) (max1: float) (max2: float) (max3: float) : Unit =
        colorModeMax_ p5 (rawColorMode colorMode) max1 max2 max3


    [<Emit("$0.colorMode($1, $2, $3, $4, $5)")>]
    let private colorModeMaxAlpha_
        (p5: P5)
        (colorMode: string)
        (max1: float)
        (max2: float)
        (max3: float)
        (alpha: float)
        : Unit =
        jsNative

    let colorModeMaxAlpha
        (p5: P5)
        (colorMode: ColorMode)
        (max1: float)
        (max2: float)
        (max3: float)
        (alpha: float)
        : Unit =
        colorModeMaxAlpha_ p5 (rawColorMode colorMode) max1 max2 max3 alpha

    [<Emit("$0.lerpColor($1, $2, $3)")>]
    let lerpColor (p5: P5) (color1: P5Color) (color2: P5Color) (amount: float) = jsNative

    let lightness (p5: P5) (color: Color) : float = emitColorFunction p5 "lightness" color

    let saturation (p5: P5) (color: Color) : float = emitColorFunction p5 "saturation" color

    [<Emit("$0.erase()")>]
    let erase (p5: P5) : Unit = jsNative

    [<Emit("$0.erase($1)")>]
    let eraseWithFill (p5: P5) (strengthFill: float) : Unit = jsNative

    [<Emit("$0.erase($1, $2)")>]
    let eraseWithFillAndStroke (p5: P5) (strengthFill: float) (strengthStroke: float) : Unit = jsNative

    [<Emit("$0.noErase()")>]
    let noErase (p5: P5) : Unit = jsNative
