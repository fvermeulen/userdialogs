using System;


namespace Acr.UserDialogs {

    public class ActionSheetDialogImpl : ActionSheetDialog {

        public override void Show() {
            throw new NotImplementedException();
        }
    }
}
/*

            var dlg = new Android.App.AlertDialog
                .Builder(this.GetTopActivity())
				.SetCancelable(false)
				.SetTitle(config.Title);

            if (config.ItemIcon != null || config.Options.Any(x => x.ItemIcon != null)) {
                var adapter = new ActionSheetListAdapter(this.GetTopActivity(), Android.Resource.Layout.SelectDialogItem, Android.Resource.Id.Text1, config);
                dlg.SetAdapter(adapter, (s, a) => config.Options[a.Which].Action?.Invoke());
            }
            else {
                var array = config
                    .Options
                    .Select(x => x.Text)
                    .ToArray();

                dlg.SetItems(array, (s, args) => config.Options[args.Which].Action?.Invoke());
            }

			if (config.Destructive != null)
				dlg.SetNegativeButton(config.Destructive.Text, (s, a) => config.Destructive.Action?.Invoke());

			if (config.Cancel != null)
				dlg.SetNeutralButton(config.Cancel.Text, (s, a) => config.Cancel.Action?.Invoke());

			Utils.RequestMainThread(() => dlg.ShowExt());
*/