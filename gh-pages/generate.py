import shutil as sh
import os
import yaml
import re

basedir = os.path.dirname(os.path.realpath(__file__))

with open(f"{basedir}/site.yaml", "r") as stream:
    site_structure = yaml.safe_load(stream)

if os.path.exists(f"{basedir}/output"):
    sh.rmtree(f"{basedir}/output")

os.mkdir(f"{basedir}/output")

sh.copyfile(f"{basedir}/index.html", f"{basedir}/output/index.html")
sh.copyfile(f"{basedir}/examples.html", f"{basedir}/output/examples.html")
sh.copyfile(f"{basedir}/reference.html", f"{basedir}/output/reference.html")


def example_to_filename(section, entry_name):
    entry_name = entry_name.replace(" ", "-")

    return f"{section}-{entry_name}.html".lower()


def reference_to_filename(name):
    name = re.sub("\\(\\).*", "", name)
    name = name.replace("/", "-")

    return f"reference-{name}.html".lower()


def replace_in_file(path, search, replace):
    file_in = open(path, "rt")
    data = file_in.read()
    data = data.replace(search, replace)
    file_in.close()

    file_out = open(path, "wt")
    file_out.write(data)
    file_out.close()


# Create separate pages for examples.
for section, entries in site_structure["examples"].items():
    for file, name in entries.items():
        filename = example_to_filename(section, name)
        src = f"{basedir}/example.html"
        dst = f"{basedir}/output/{filename}"

        sh.copyfile(src, dst)

        title = f"{section} - {name}"
        replace_in_file(dst, "$title", title)

        replace_in_file(dst, "$file", file)
        replace_in_file(dst, "$escapedFile", file.replace("/", "%2F"))

        p5js_link = f"https://p5js.org/examples/{filename}"
        replace_in_file(dst, "$p5jsLink", p5js_link)

# Create listing of pages for examples.
example_list = ""
for section, entries in site_structure["examples"].items():
    example_list += f"<h3>{section}</h3>"
    example_list += "<ul>"
    for name in entries.values():
        link = example_to_filename(section, name)
        example_list += f'<li><a href="{link}">{name}</a></li>'
    example_list += "</ul>"
example_list += ""

replace_in_file(f"{basedir}/output/examples.html", "$exampleList", example_list)

reference_example_template = """
<div class="canvas-wrapper canvas-wrapper-$index"></div>

<script>
    PerfectFifth.runReference("$file", ".canvas-wrapper-$index")
</script>
<script
    src="https://emgithub.com/embed-v2.js?target=https%3A%2F%2Fgithub.com%2Fmark-gerarts%2Fperfect-fifth%2Fblob%2Fmain%2Fsrc%2FPerfectFifth.Reference%2F$escapedFile.fs&style=github&type=code&showFileMeta=on&showLineNumbers=on&showFullPath=on&showCopy=on&fetchFromJsDelivr=on"></script>
"""

# Create separate pages for reference items.
for section, entries in site_structure["reference"].items():
    for name, sketches in entries.items():
        filename = reference_to_filename(name)
        src = f"{basedir}/reference-item.html"
        dst = f"{basedir}/output/{filename}"

        sh.copyfile(src, dst)

        examples = []
        for index, sketch in enumerate(sketches):
            example = reference_example_template
            example = example.replace("$index", str(index))
            example = example.replace("$file", sketch)
            example = example.replace("$escapedFile", sketch.replace("/", "%2F"))
            examples.append(example)

        replace_in_file(dst, "$title", name)

        replace_in_file(dst, "$examples", "".join(examples))

        p5js_name = re.sub("\\(\\).*", "", name)
        if not p5js_name.startswith("p5"):
            p5js_name = "p5/" + p5js_name

        p5js_link = f"https://p5js.org/reference/#/{p5js_name}"
        replace_in_file(dst, "$p5jsLink", p5js_link)


# Create listing of pages for reference.
reference_list = ""
for section, entries in site_structure["reference"].items():
    reference_list += f"<h3>{section}</h3>"
    reference_list += "<ul>"
    for name in entries.keys():
        link = reference_to_filename(name)
        reference_list += f'<li><a href="{link}">{name}</a></li>'
    reference_list += "</ul>"
reference_list += ""

replace_in_file(f"{basedir}/output/reference.html", "$referenceList", reference_list)
