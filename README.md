# Perfect Fifth

F# Fable bindings for p5js, with some extra functional sugar on top.

⚠️ This is a work in progress. It can't currently be used as a library, and it
is still missing most functionality and all documentation.

## Library

TODO

## Examples

The `PerfectFifth.Examples` project contains examples ported from the [p5js
site](https://p5js.org/examples/).

### Installation

```bash
dotnet restore src/PerfectFifth.Examples
```

```bash
npm i p5
```

### Usage

```bash
npm start
```

Change the script in `public/index.html` to the example you want to run, e.g.

```javascript
PerfectFifth.runSketch("structure/coordinates")
```

As said above, this is very much a work in progress.

## Todo

- Implement all of p5js
- Extract this to a proper library & publish
  - E.g. find a solution for `sketch.js` (probably publish it as an npm package)
- Documentation & docblocks
- For simplicity's sake, should add a global mode variant as well
- Test suite could possibly be something like playwright on the examples repo
- Minify bundle.js output
- Potentially add examples from the reference as well

## Credits

Inspired by [Haskell's Gloss](http://gloss.ouroborus.net/) And [Clojure's
Quil](https://github.com/quil/quil).
