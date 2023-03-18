#!/usr/bin/env sh
set -xe

npm run build
gh-pages/venv/bin/python gh-pages/generate.py
cp public/bundle.js gh-pages/output
cp public/fable.ico gh-pages/output
gh-pages/venv/bin/python -m http.server -d gh-pages/output
