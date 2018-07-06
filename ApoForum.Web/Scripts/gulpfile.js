/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp');
var merge = require('merge-stream');

gulp.task('test', function () {
    var bootstrap = gulp.src('~/Scripts/Admin/*.js')
      .pipe(gulp.dest('.'));

    return merge(bootstrap);
});