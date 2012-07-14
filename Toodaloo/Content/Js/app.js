$(function() {

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

	$('#edit-todo').live('submit', function(e) {
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

	$('.cancel-edit').live('click', function(e) {
		$.ajax({
			type: 'POST',
			url: $(this).attr('href'),
			success: function(data, status, xhr) {
				eval(data);
			}
		});

		return false;
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
		$.ajax({
			type: 'POST',
			url: $(this).attr('href'),
			success: function(data, status, xhr) {
				eval(data);
			}
		});

		return false;
	});

});