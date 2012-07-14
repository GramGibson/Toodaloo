$(function() {

	$('#new-todo').submit(function(e) {
		e.preventDefault();

		$.ajax({
			type: $(this).attr('method'),
			url: $(this).attr('action'),
			data: $(this).serialize(),
			success: function(data, status, xhr) {
				eval(data);
			}
		});
	});

	$('#edit-todo').live('submit', function(e) {
		e.preventDefault();

		$.ajax({
			type: $(this).attr('method'),
			url: $(this).attr('action'),
			data: $(this).serialize(),
			success: function(data, status, xhr) {
				eval(data);
			}
		});
	});

	$('.cancel-edit').live('click', function(e) {
		e.stopPropagation();
		e.preventDefault();

		$.ajax({
			type: 'POST',
			url: $(this).attr('href'),
			success: function(data, status, xhr) {
				eval(data);
			}
		});
	});

	$('.todo').live('click', function(e) {
		$.ajax({
			type: 'GET',
			url: '/todo/edit/' + $(e.currentTarget).attr('id').replace('todo_', ''),
			success: function(data, status, xhr) {
				eval(data);
			}
		});
	});

	$('.delete').live('click', function(e) {
		e.stopPropagation();
		e.preventDefault();

		$.ajax({
			type: 'POST',
			url: $(this).attr('href'),
			success: function(data, status, xhr) {
				eval(data);
			}
		});
	});

});