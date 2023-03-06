namespace P5

module Typography =

    open Fable.Core
    open P5.Core

    open Fable.Core.JsInterop

    [<Emit("$0.textSize()")>]
    let textSize (p5: P5) : int = jsNative

    let getTextSize = textSize

    [<Emit("$0.textSize($1)")>]
    let setTextSize (p5: P5) (size: int) : Unit = jsNative

    type HorizontalAlign =
        | Left
        | Center
        | Right

    type VerticalAlign =
        | Top
        | Bottom
        | Center
        | Baseline

    type TextAlign =
        { horizontal: HorizontalAlign
          vertical: VerticalAlign }

    type TextAlignRaw =
        { horizontal: string; vertical: string }

    let private rawHorizontalAlign align =
        match align with
        | Left -> "left"
        | HorizontalAlign.Center -> "center"
        | Right -> "right"

    let private rawVerticalAlign align =
        match align with
        | Top -> "top"
        | Bottom -> "bottom"
        | Center -> "center"
        | Baseline -> "alphabetic" // No typo.

    [<Emit("$0.textAlign($1, $2)")>]
    let private setTextAlign_ (p5: P5) (horizontal: string) (vertical: string) = jsNative

    let defaultTextAlign: TextAlign =
        { horizontal = Left
          vertical = Baseline }

    let setTextAlign (p5: P5) (align: TextAlign) : Unit =
        setTextAlign_ p5 (rawHorizontalAlign align.horizontal) (rawVerticalAlign align.vertical)

    [<Emit("$0.textAlign()")>]
    let private getTextAlign_ (p5: P5) : TextAlignRaw = jsNative

    let getTextAlign (p5: P5) : TextAlign =
        let align = getTextAlign_ p5

        let horizontal =
            match align.horizontal with
            | "left" -> Left
            | "center" -> HorizontalAlign.Center
            | "right" -> Right
            | _ ->
                failwith
                    "Received invalid value for p5.textAlign. This is probably a version mismatch between Perfect Fifth and P5"

        let vertical =
            match align.vertical with
            | "top" -> Top
            | "bottom" -> Bottom
            | "center" -> Center
            | "alphabetic" -> Baseline
            | _ ->
                failwith
                    "Received invalid value for p5.textAlign. This is probably a version mismatch between Perfect Fifth and P5"

        { horizontal = horizontal
          vertical = vertical }



    // TODO: width/height
    [<Emit("$0.text($1, $2, $3)")>]
    let text (p5: P5) (str: string) (x: float) (y: float) : Unit = jsNative
