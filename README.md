# Perfect Fifth

[Homepage (with examples!)](https://mark-gerarts.github.io/perfect-fifth/)

Perfect Fifth is a Processing-like creative coding environment for F#. It is a
thin wrapper around [p5js](https://p5js.org), with some extra functional sugar
on top.

⚠️ This is a work in progress. It can't currently be used as a library, and it
is still missing most functionality and all documentation.

## Installation

⚠️ Installation as a library is not yet possible. These instructions are for
getting the examples project up & running.

```bash
dotnet restore src/PerfectFifth.Examples
```

```bash
npm i
```

Start a local server with hot reload:

```bash
npm start
```

Change the script in `public/index.html` to the example you want to run, e.g.

```javascript
PerfectFifth.runSketch("Structure/Coordinates")
```

As said above, this is very much a work in progress.

## Examples

A part of the examples on the p5js site are ported to Perfect Fifth. You can
find the sketches and their source code on the [project
site](https://mark-gerarts.github.io/perfect-fifth/examples.html).

## Usage

You can create a sketch in four different ways, depending on your use case:

- Use `display` to render a single frame, without animation.
- Use `animate` to create an animation that updates itself based on time.
- Use `simulate` to create a stateful simulation.
- Use `play` to create a simulation that also handles input events.

### Display

Using `display`, you can draw a single frame and nothing more.

```fsharp
// Definition:
let display
  (node: Node) // Element to render the canvas.
  (draw: P5 -> Unit) // Draw function that gets called a single time.
  : Unit = ...
```

The first argument is `node`, the target HTML element where the sketch should be
rendered. It can be set in three different ways:

```fsharp
type Node =
    // The query selector of an element.
    | Selector of string
    // A Fable Browser.Dom.Element, e.g. the result of document.querySelector
    | Element of Browser.Types.Element
    // Nothing. Create the canvas yourself in `draw` using `createCanvas`, or
    // let P5 handle it.
    | None
```

The second argument is the draw function that will be called a single time. It
gets passed the `p5` context variable, which is needed for all p5 functionality.

For example:

```fsharp
module DrawExample

open Browser.Dom
open P5.Core
open P5.Rendering
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    resizeCanvas p5 720 400
    stroke p5 (Grayscale 255)

    let y = (height p5 |> float) * 0.5
    let width = width p5 |> float

    background p5 (Grayscale 0)
    line2D p5 0 y width y

display (Selector ".canvas-wrapper") draw

// Or
display (Element (document.querySelector ".canvas-wrapper")) draw

// Or
display None draw
```

### Animate

`animate` is used to create an animation. Its `draw` function gets passed the
elapsed milliseconds since the start of the sketch.

```fsharp
// Definition:
let animate
    (node: Node) // Element to render the canvas.
    (setup: P5 -> Unit) // Setup function that gets called once, before the sketch starts.
    (draw: P5 -> int -> Unit) // Draw function that receives the time elapsed in ms.
  : Unit = ...
```

TODO: add an example.

### Simulate

With `simulate` you can create a simulation that is able to update its state
every frame. The state can be any data type. For example, a simple counter can
use a single integer, while a complex simulation might use a big record type.

You provide an initial state in the setup function, which can then be updated
every step using the `update` function.

```fsharp
// Definition:
let simulate
    (node: Node) // Element to render the canvas.
    (setup: P5 -> 'a) // Setup function that gets called once, before the sketch starts. Returns the initial state.
    (update: P5 -> 'a -> 'a) // A function to step the state one iteration.
    (draw: P5 -> 'a -> Unit) // A function to draw something based on the current state.
    : Unit = ...
```

TODO: add an example.

### Play

Much the same as `simulate`, but `play` is able to handle input as well.

```fsharp
// Definition:
let play
    (node: Node) // Element to render the canvas.
    (setup: P5 -> 'a) // Setup function that gets called once, before the sketch starts. Returns the initial state.
    (update: P5 -> 'a -> 'a) // A function to step the state one iteration.
    (draw: P5 -> 'a -> Unit) // A function to draw something based on the current state.
    (eventHandler: P5 -> Event -> 'a -> 'a) // A function to update the state based on input events.
    : Unit = ...
```

TODO: add an example.

## Remarks

TODO: explain why p5 needs to be passed to everything.

## Todo

- Implement all of p5js
- Documentation & docblocks + check if these can be extracted/published
  somewhere
- Publish the package when sufficiently featured
- For simplicity's sake, could add a global mode variant as well
- Test suite could possibly be something like playwright on the examples repo
- Minify bundle.js output in examples project
- Potentially add examples from the reference as well

## Credits

Inspired by [Haskell's Gloss](http://gloss.ouroborus.net/), [Clojure's
Quil](https://github.com/quil/quil), and [aolney's Fable P5
Demo](https://github.com/aolney/fable-p5-demo). Made possible with
[Fable](https://fable.io/).
