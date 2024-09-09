<!DOCTYPE html>
<html>
<head>
<style>
body {
  counter-reset: section;
}

h2::before {
  counter-increment: section;
  content: "Section " counter(section) ": ";
}
</style>
</head>
<body>

<h1>Using CSS Counters</h1>

<h2>HTML Tutorial</h2>
<h2>CSS Tutorial</h2>
<h2>JavaScript Tutorial</h2>
<h2>Python Tutorial</h2>
<h2>SQL Tutorial</h2>

</body>
</html>
