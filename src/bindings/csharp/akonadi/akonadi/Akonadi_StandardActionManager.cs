//Auto-generated by kalyptus. DO NOT EDIT.
namespace Akonadi {
    using Kimono;
    using System;
    using Qyoto;
    /// <remarks>
    ///  Manages generic Akonadi actions common for all types. This covers
    ///  creating of the actions with appropriate labels, icons, shortcuts
    ///  etc., updating the action state depending on the current selection
    ///  as well as default implementations for the actual operations.
    ///  If the default implementation is not appropriate for your application
    ///  you can still use the state tracking by disconnecting the triggered()
    ///  signal and re-connecting it to your implementation. The actual KAction
    ///  objects can be retrieved by calling createAction() or action() for that.
    ///  If the default look and feel (labels, icons, shortcuts) of the actions
    ///  is not appropriate for your application, you can access them as noted
    ///  above and customize them to your needs. Additionally, you can set a
    ///  KLocalizedString which should be used as a action label with correct
    ///  plural handling for actions operating on multiple objects with
    ///  setActionText().
    ///  Finally, if you have special needs for the action states, connect to
    ///  the actionStateUpdated() signal and adjust the state accordingly.
    ///  The following actions are provided (KAction name in parenthesis):
    ///  - Creation of a new collection (<code>akonadi_collection_create</code>)
    ///  - Copying of selected collections (<code>akonadi_collection_copy</code>)
    ///  - Deletion of selected collections (<code>akonadi_collection_delete</code>)
    ///  - Synchronization of selected collections (<code>akonadi_collection_sync</code>)
    ///  - Showing the collection properties dialog for the current collection (<code>akonadi_collection_properties</code>)
    ///  - Copying of selected items (<code>akonadi_itemcopy</code>)
    ///  - Pasting collections, items or raw data (<code>akonadi_paste</code>)
    ///  - Deleting of selected items (<code>akonadi_item_delete</code>)
    ///  - Managing local subscriptions (<code>akonadi_manage_local_subscriptions</code>)
    ///  The following example shows how to use standard actions in your application:
    ///  @code
    ///  Akonadi.StandardActionManager actMgr = new Akonadi.StandardActionManager( actionCollection(), this );
    ///  actMgr.SetCollectionSelectionModel( collectionView.CollectionSelectionModel() );
    ///  actMgr.CreateAllActions();
    ///  @endcode
    ///  Additionally you have to add the actions to the KXMLGUI file of your application,
    ///  using the names listed above.
    ///  If you only need a subset of the actions provided, you can call createAction()
    ///  instead of createAllActions() for the action types you want.
    ///  @todo collection deleting and sync do not support multi-selection yet
    ///  See <see cref="IStandardActionManagerSignals"></see> for signals emitted by StandardActionManager
    /// </remarks>        <author> Volker Krause <vkrause@kde.org>
    ///  </author>
    ///         <short> Manages generic actions for collection and item views. </short>
    [SmokeClass("Akonadi::StandardActionManager")]
    public class StandardActionManager : QObject, IDisposable {
        protected StandardActionManager(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(StandardActionManager), this);
        }
        /// <remarks>
        ///  Describes the supported actions.
        ///      </remarks>        <short>    Describes the supported actions.</short>
        public enum TypeOf {
            CreateCollection = 0,
            CopyCollections = 1,
            DeleteCollections = 2,
            SynchronizeCollections = 3,
            CollectionProperties = 4,
            CopyItems = 5,
            Paste = 6,
            DeleteItems = 7,
            ManageLocalSubscriptions = 8,
            LastType = 9,
        }
        /// <remarks>
        ///  Creates a new standard action manager.
        /// <param> name="actionCollection" The action collection to operate on.
        /// </param><param> name="parent" The parent widget.
        ///      </param></remarks>        <short>    Creates a new standard action manager.</short>
        public StandardActionManager(KActionCollection actionCollection, QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("StandardActionManager##", "StandardActionManager(KActionCollection*, QWidget*)", typeof(void), typeof(KActionCollection), actionCollection, typeof(QWidget), parent);
        }
        public StandardActionManager(KActionCollection actionCollection) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("StandardActionManager#", "StandardActionManager(KActionCollection*)", typeof(void), typeof(KActionCollection), actionCollection);
        }
        /// <remarks>
        ///  Sets the collection selection model based on which the collection
        ///  related actions should operate. If none is set, all collection actions
        ///  will be disabled.
        ///      </remarks>        <short>    Sets the collection selection model based on which the collection  related actions should operate.</short>
        public void SetCollectionSelectionModel(QItemSelectionModel selectionModel) {
            interceptor.Invoke("setCollectionSelectionModel#", "setCollectionSelectionModel(QItemSelectionModel*)", typeof(void), typeof(QItemSelectionModel), selectionModel);
        }
        /// <remarks>
        ///  Sets the item selection model based on which the item related actions
        ///  should operate. If none is set, all item actions will be disabled.
        ///      </remarks>        <short>    Sets the item selection model based on which the item related actions  should operate.</short>
        public void SetItemSelectionModel(QItemSelectionModel selectionModel) {
            interceptor.Invoke("setItemSelectionModel#", "setItemSelectionModel(QItemSelectionModel*)", typeof(void), typeof(QItemSelectionModel), selectionModel);
        }
        /// <remarks>
        ///  Creates the action of the given type and adds it to the action collection
        ///  specified in the constructor if it does not exist yet. The action is
        ///  connected to its default implementation provided by this class.
        ///      </remarks>        <short>    Creates the action of the given type and adds it to the action collection  specified in the constructor if it does not exist yet.</short>
        public KAction CreateAction(Akonadi.StandardActionManager.TypeOf type) {
            return (KAction) interceptor.Invoke("createAction$", "createAction(Akonadi::StandardActionManager::Type)", typeof(KAction), typeof(Akonadi.StandardActionManager.TypeOf), type);
        }
        /// <remarks>
        ///  Convenience method to create all standard actions.
        /// </remarks>        <short>    Convenience method to create all standard actions.</short>
        ///         <see> createAction</see>
        public void CreateAllActions() {
            interceptor.Invoke("createAllActions", "createAllActions()", typeof(void));
        }
        /// <remarks>
        ///  Returns the action of the given type, 0 if it has not been created (yet).
        ///      </remarks>        <short>    Returns the action of the given type, 0 if it has not been created (yet).</short>
        public KAction Action(Akonadi.StandardActionManager.TypeOf type) {
            return (KAction) interceptor.Invoke("action$", "action(Akonadi::StandardActionManager::Type) const", typeof(KAction), typeof(Akonadi.StandardActionManager.TypeOf), type);
        }
        /// <remarks>
        ///  Sets the label of the action <code>type</code> to <code>text</code>, which is used during
        ///  updating the action state and substituted according to the number of
        ///  selected objects. This is mainly useful to customize the label of actions
        ///  that can operate on multiple objects.
        ///  Example:
        ///  @code
        ///  acctMgr.SetActionText( Akonadi.StandardActionManager.CopyItems,
        ///                          ki18np( "Copy Mail", "Copy %1 Mails" ) );
        ///  @endcode
        ///      </remarks>        <short>    Sets the label of the action <code>type</code> to <code>text</code>, which is used during  updating the action state and substituted according to the number of  selected objects.</short>
        public void SetActionText(Akonadi.StandardActionManager.TypeOf type, KLocalizedString text) {
            interceptor.Invoke("setActionText$#", "setActionText(Akonadi::StandardActionManager::Type, const KLocalizedString&)", typeof(void), typeof(Akonadi.StandardActionManager.TypeOf), type, typeof(KLocalizedString), text);
        }
        ~StandardActionManager() {
            interceptor.Invoke("~StandardActionManager", "~StandardActionManager()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~StandardActionManager", "~StandardActionManager()", typeof(void));
        }
        protected new IStandardActionManagerSignals Emit {
            get { return (IStandardActionManagerSignals) Q_EMIT; }
        }
    }

    public interface IStandardActionManagerSignals : IQObjectSignals {
        /// <remarks>
        ///  This signal is emitted whenever the action state has been updated.
        ///  In case you have special needs for changing the state of some actions,
        ///  connect to this signal and adjust the action state.
        ///      </remarks>        <short>    This signal is emitted whenever the action state has been updated.</short>
        [Q_SIGNAL("void actionStateUpdated()")]
        void ActionStateUpdated();
    }
}
