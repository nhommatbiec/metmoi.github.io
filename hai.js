#views/layout.pug
 
doctype html
html
  head
    title= title
    link(rel='stylesheet', href='/stylesheets/style.css')
    link(rel='stylesheet', href='https://bootswatch.com/paper/bootstrap.css')
    script(src='https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js')
    script(src='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js')
  body
  ul.nav.navbar-nav.navbar-right
  li
    a(href='/books') View Books
  li
    a(href='/books/add') Add New Book
  li
    a(href='/genres') View Genres
  li
    a(href='/genres/add') Add New Genre