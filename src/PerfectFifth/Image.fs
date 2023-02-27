namespace P5

module Image =

    open Fable.Core
    open P5.Core

    /// TODO: image accepts other values as well; also width and height.
    [<Emit("$0.image($1, $2, $3)")>]
    let image (p5: P5) (image: P5) (x: float) (y: float) : Unit = jsNative
