﻿$(function() {

	$('#new-todo').submit(function(e) {
		$.ajax({
			type: $(this).attr('method'),
			url: $(this).attr('action'),
			data: $(this).serialize(),
			success: function(data, status, xhr) {
				eval(data);
			}
		});

		return false;
	});

	$('#container').on('click', '.todo-checkbox', function(e) {
		$form = $(this).closest('form');

		$.ajax({
			type: $form.attr('method'),
			url: $form.attr('action'),
			data: $form.serialize(),
			success: function(data, status, xhr) {
				eval(data);
			}
		});
	});

	$('#container').on('mouseenter', '.todo', function(e) {
		$(this).find('.controls').show();
	});

	$('#container').on('mouseleave', '.todo', function(e) {
		$(this).find('.controls').hide();
	});

	$('#container').on('submit', '#edit-todo', function(e) {
		$.ajax({
			type: $(this).attr('method'),
			url: $(this).attr('action'),
			data: $(this).serialize(),
			success: function(data, status, xhr) {
				eval(data);
			}
		});

		return false;
	});

	$('#container').on('blur', '.edit-todo-description', function(e) {
		$('#edit-todo').submit();
	});

	$('#container').on('click', '.edit', function(e) {
		$.ajax({
			type: 'GET',
			url: $(this).attr('href'),
			success: function(data, status, xhr) {
				eval(data);
			}
		});

		return false;
	});

	$('#container').on('click', '.delete', function(e) {
		$.ajax({
			type: 'POST',
			url: $(this).attr('href'),
			success: function(data, status, xhr) {
				eval(data);
			}
		});

		return false;
	});

	$('#container').on('click', '.delete-completed-todo', function(e) {
		$.ajax({
			type: 'POST',
			url: $(this).data('url'),
			success: function(data, status, xhr) {
				eval(data);
			}
		});

		return false;
	});

});